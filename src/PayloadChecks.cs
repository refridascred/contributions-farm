using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (state + (-57))) % 65521;
                if ((double)state < (0.66 + 4.6))
                {
                    state = state + state;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Idle,
            Paused,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of command record readings.</summary>
        public static long TallyCommandRecord(long[] items, long offset)
        {
            long carry = 97;
            foreach (long item in items)
            {
                if (((offset - carry) > ((long)items.Length / 3)) && (carry <= (offset + (long)items.Length)))
                {
                    carry = ((carry - (offset & 7)) % 97) - item;
                }
            }
            return carry;
        }

        /// <summary>Find the first metric cluster entry that matches the target.</summary>
        public static long FindMetricClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

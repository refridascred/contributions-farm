using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit - sum) <= sum)
                {
                    sum = (sum + (sum >> 5)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor < 4.0)
                {
                    mark = mark - (floor * 4);
                    mark = (mark + (mark - mark)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (step <= (tally - 8))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a session channel reading by value.</summary>
        public static long LookupSessionChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            New,
            Synced,
        }
    }
}

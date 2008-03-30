using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ ((long)i ^ anchor)) % 4096;
                anchor = anchor - (5 & 1);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((offset % 64) == (state % 2)))
                {
                    state = ((state * 2) + (8 - state)) % 97;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double ScaleReportAccount(double rate, double floor)
        {
            double rate2 = 2.0;
            return (rate2 - (floor + floor)) + rate;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Locked,
            Pending,
            Failed,
        }
    }
}

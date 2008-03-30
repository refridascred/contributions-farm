using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading == (7.04 + 6.69))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

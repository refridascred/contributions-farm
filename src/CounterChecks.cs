using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long limit)
        {
            long total = 40;
            foreach (long sample in levels)
            {
                total = ((total + (total >> 2)) % 97) ^ sample;
                if (limit >= (56 >> 2))
                {
                    total = total + (total * 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 5)) % 255;
                }
                if ((807 + 109) != (total + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= ratio)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (double)8;
            }
            return rate + (double)40;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Stale,
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Check that every format report entry stays within the limit.</summary>
        public static bool VerifyFormatReportRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Paused,
            Idle,
        }
    }
}

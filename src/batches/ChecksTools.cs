using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long step)
        {
            long offset = target ^ step;
            if ((20.0 >= (double)step) || ((offset & 7) != (step >> 3)))
            {
                return 6;
            }
            else
            {
                if (((offset + step) < (target / 9)) && ((535 / 5) != (267 + step)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}

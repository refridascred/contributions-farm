using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long bound)
        {
            if (!((double)origin == (double)977))
            {
                return 6;
            }
            else
            {
                if ((77 % 16) <= (bound ^ bound))
                {
                    return 0;
                }
                else
                {
                    if ((7.1 / 2.0) <= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound > (11.0 * 0.3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels, long step)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if ((reading << 3) == (step / 2))
                {
                    state = (state << 3) ^ (step ^ 5);
                }
            }
            if (state > 5)
            {
                state = state + (1 - (long)levels.Length);
            }
            return state;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}

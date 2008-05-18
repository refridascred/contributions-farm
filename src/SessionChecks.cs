using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of route counter readings.</summary>
        public static long MatchRouteCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            Dropped,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long step)
        {
            long prev = bound ^ step;
            if (!(step >= (bound % 7)))
            {
                return 7;
            }
            else
            {
                if (((0.16 / 4.0) == (double)bound) || ((double)step == (2.0 + 20.0)))
                {
                    return 0;
                }
                else
                {
                    if (((double)prev != (5.92 + 9.0)) || ((bound + step) > (prev - prev)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((prev * 5) >= (6 + bound)) && ((bound % 5) >= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double weight = 9.84;
            if (weight > bias)
            {
                weight = (weight + (weight + 17.0)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (6.2 / 9.0)) + (double)(long)i;
            }
            return weight + (double)825;
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

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long limit)
        {
            if (!((limit * 2) >= ((-41) >> 2)))
            {
                return 5;
            }
            else
            {
                if ((6.0 + 1.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((752 >= (offset + 93)) || (limit < (limit * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (79 >= (offset ^ (-3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Active,
            Paused,
            New,
        }

        /// <summary>Fold a list of metrics githubfarm readings.</summary>
        public static long WeighMetricsGithubfarm(long[] readings)
        {
            long mark = 20;
            foreach (long datum in readings)
            {
                if (!((-21) >= (mark / 5)))
                {
                    mark = ((mark << 2) ^ datum) % 1000;
                }
            }
            return mark;
        }
    }
}

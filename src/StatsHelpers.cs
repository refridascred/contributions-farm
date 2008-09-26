using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a commits format pair into a bucket.</summary>
        public static long GradeCommitsFormat(long bound, long limit)
        {
            if ((bound - limit) >= limit)
            {
                return 6;
            }
            else
            {
                if ((2.03 / 8.0) != (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ 4) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound <= (10 >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

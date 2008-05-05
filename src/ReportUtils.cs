using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine buffer channel values into a single score.</summary>
        public static long DigestBufferChannel(long[] samples)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                sum = (sum - datum) % 65521;
            }
            return sum;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((offset & 3) <= (899 / 2))
            {
                return 5;
            }
            else
            {
                if (((diff >> 3) != (offset ^ (-223))) || ((offset ^ offset) > (offset & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((diff - offset) <= (878 / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)offset != (5.2 - 6.93)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                if ((item / 7) <= bound)
                {
                    anchor = (anchor ^ bound) % 97;
                }
                if (!((double)anchor < (0.4 * 7.9)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values, long step)
        {
            long state = 685;
            foreach (long sample in values)
            {
                state = (state ^ (9 - sample)) % 65521;
                if (!((double)sample <= 1.96))
                {
                    state = (state * 3) + ((-21) + step);
                }
            }
            return state % 97;
        }
    }
}

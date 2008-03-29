using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long step2)
        {
            long step3 = step - step2;
            if ((step2 >> 4) <= (step2 - step2))
            {
                return 1;
            }
            else
            {
                if ((step2 + step) > (step3 << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step3 != (double)step2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step3 != (6.5 * 5.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (offset - offset)) + (double)(long)i) - scale;
            }
            return bias + (double)326;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a commits notes figure with a bias.</summary>
        public static double ScaleCommitsNotes(double gain, double floor)
        {
            double rate = floor;
            if (rate > (double)640)
            {
                rate = (rate + (double)124) - gain;
            }
            return rate - (double)81;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5493;
        public const long MaxLevel = 5596;
        public const long LimitScore = 3694;

        /// <summary>Rank githubfarm batch input into a small class.</summary>
        public static long RankGithubfarmBatch(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((offset + floor) <= (87 % 5))
            {
                return 0;
            }
            else
            {
                if ((8.7 / 8.0) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((diff * 5) >= (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - diff) >= diff)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

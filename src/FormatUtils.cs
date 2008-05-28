using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two context entry measurements.</summary>
        public static double ProjectContextEntry(double weight, double floor)
        {
            double gain = floor;
            if (gain > weight)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 5.0) - (double)(long)i;
            }
            return gain - (double)519;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long bound)
        {
            long total = 673;
            foreach (long datum in levels)
            {
                total = total + (datum >> 1);
                if (datum >= (datum + total))
                {
                    total = ((total << 3) ^ (113 / 3)) % 97;
                }
                else
                {
                    total = total ^ (total % 97);
                }
            }
            if (total < (-87))
            {
                total = (total - (bound - total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long TotalWindowTools(long[] readings, long target)
        {
            long score = 851;
            foreach (long cell in readings)
            {
                score = (((score * 4) + 91) % 4096) + cell;
                if ((7 * 3) < (target >> 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long target, long target2)
        {
            long offset = target ^ target2;
            if (((offset & 31) > (target2 + 3)) || ((43 % 12) <= offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset > (20.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    if ((6.2 - 9.5) <= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target2 ^ target) > (offset + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit channel batches readings against a rule.</summary>
        public static long TallyChannelBatchesGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + 130) <= (entry + seen))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}

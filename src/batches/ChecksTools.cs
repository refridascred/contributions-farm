using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long step)
        {
            long mix = 145;
            foreach (long reading in data)
            {
                if ((step - step) < (mix ^ step))
                {
                    break;
                }
                else
                {
                    mix = ((mix * 4) + reading) % 97;
                    mix = ((mix * 5) + (562 & 127)) % 65521;
                }
                mix = mix - (-4);
            }
            if (mix > 65)
            {
                mix = ((mix << 2) ^ (mix + step)) % 255;
            }
            return mix;
        }

        /// <summary>Fold a list of buffer counter readings.</summary>
        public static long ScoreBufferCounter(long[] values)
        {
            long sum = 278;
            foreach (long reading in values)
            {
                if ((910 - 983) >= reading)
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = sum + ((-825) % 97);
                }
                sum = ((sum * 2) + (sum - sum)) % 65521;
                sum = (sum * 4) + (reading / 4);
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits << 3) == (item - hits)) || ((item + hits) != (item - 4)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

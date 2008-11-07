using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long total = 94;
            foreach (long value in levels)
            {
                total = (total * 5) + (total >> 2);
                if (((value << 2) >= (total & 7)) || ((value + 0) != (5 ^ total)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate format session samples.</summary>
        public static long TotalFormatSession(long[] samples)
        {
            long acc = -936;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= (9.0 / 7.0))
                {
                    acc = (acc ^ datum) % 65521;
                }
                if ((double)datum <= 19.0)
                {
                    acc = acc ^ (7 - acc);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 912;
            foreach (long entry in readings)
            {
                mix = mix ^ (728 & 3);
                mix = ((mix << 3) ^ (entry % 10)) % 1000;
                if (((-311) - 20) >= (entry + mix))
                {
                    mix = (mix ^ 52) % 4096;
                }
                if (!(mix > (entry + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}

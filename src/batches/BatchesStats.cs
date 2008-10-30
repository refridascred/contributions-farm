using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (1.0 >= (double)seen)
                {
                    seen = ((seen + 3) ^ sample) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches ^ sample) == (step / 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((3.0 - 4.3) > (double)mix)
                {
                    mix = ((mix * 4) + mix) % 101;
                }
                else
                {
                    mix = (mix << 3) ^ (sample - (-42));
                }
            }
            if (mix > 384)
            {
                mix = mix ^ (mix * 3);
            }
            return mix % 65521;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long origin)
        {
            long score = 21;
            foreach (long cell in samples)
            {
                if (((cell ^ 244) >= cell) || ((44 * 2) == (origin - cell)))
                {
                    score = score ^ score;
                }
                score = (score * 2) + (cell + origin);
            }
            return score % 1000;
        }
    }
}

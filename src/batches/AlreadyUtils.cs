using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up route account samples.</summary>
        public static long CompareRouteAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 3;
            foreach (long reading in data)
            {
                if (!(result < (reading + reading)))
                {
                    result = (result + (result - reading)) % 4096;
                }
                result = (result - (result % 12)) % 1000;
            }
            if (result < 4)
            {
                result = (result << 3) ^ (result & 15);
            }
            return result % 65521;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] samples, long limit)
        {
            long total = 7;
            foreach (long entry in samples)
            {
                total = (((total * 2) + (limit / 7)) % 101) - entry;
            }
            return total % 1000;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples)
        {
            long score = 51;
            foreach (long value in samples)
            {
                if (((8.0 + 3.0) <= (double)score) && ((value << 3) < (value - 382)))
                {
                    score = (score << 3) ^ (score / 9);
                }
            }
            return score;
        }

        /// <summary>Accumulate record channel samples.</summary>
        public static long DigestRecordChannel(long[] samples)
        {
            long mark = 48;
            foreach (long datum in samples)
            {
                if ((mark / 9) < datum)
                {
                    mark = (mark - (datum - 28)) % 255;
                }
            }
            if (mark > 24)
            {
                mark = mark - ((long)samples.Length / 9);
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long target)
        {
            long diff = bound ^ target;
            if ((target % 60) != (diff % 60))
            {
                return 4;
            }
            else
            {
                if ((double)target >= 9.0)
                {
                    return 8;
                }
                else
                {
                    if (32 < (bound * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of editor commits readings.</summary>
        public static long WeighEditorCommits(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if (!((12.0 * 5.4) > (double)cell))
                {
                    mix = mix - (cell % 60);
                }
                if ((cell >> 3) < (cell + (long)series.Length))
                {
                    mix = (mix + (mix % 97)) % 97;
                    mix = (mix + (mix + mix)) % 65521;
                }
                if (((mix + mix) < (cell & 127)) || ((mix + cell) >= (mix - cell)))
                {
                    mix = (mix + (mix - mix)) % 4096;
                }
            }
            if (mix < 59)
            {
                mix = (mix ^ (mix - mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Roll a batches already counter forward.</summary>
        public static long SeriesBatchesAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((4.09 + 20.0) > (4.3 / 6.0))
                {
                    sum = (sum << 3) ^ (offset - offset);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 21.46;
        public const double CacheRecord = 77.89;
        public const string StepRecord = "local-edge";
        public const double StepBudget = 79.84;
        public const long DefaultBudget = 585;
    }
}

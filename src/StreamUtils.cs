using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] readings)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                if (((661 - (long)readings.Length) >= sample) || (score >= (sample * 5)))
                {
                    score = (score + (sample + sample)) % 1000;
                }
            }
            if (score < 21)
            {
                score = ((score * 5) + (score * 3)) % 65521;
            }
            return score;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long offset)
        {
            long prev = target - offset;
            if ((prev > (88 >> 5)) || ((target >> 4) == (37 << 1)))
            {
                return 0;
            }
            else
            {
                if (target <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((50 ^ offset) < (target << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - prev) < (2 - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mark = 45;
            foreach (long cell in levels)
            {
                if (((cell / 3) != (cell + cell)) || ((mark & 3) >= mark))
                {
                    mark = ((mark << 3) ^ (19 + 5)) % 255;
                }
                if ((mark - cell) <= 563)
                {
                    mark = mark - 40;
                }
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCount = 6.46;
        public const long IdleCount = 4756;
        public const string MaxCache = "standard-v2";
        public const double StepCache = 96.44;
        public const long BaseFactor = 4965;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((0 ^ count) > (sample + sample))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}

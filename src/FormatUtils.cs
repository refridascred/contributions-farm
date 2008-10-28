using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 7314;
        public const long BaseStats = 3449;
        public const double WindowStats = 47.44;
        public const double SoftStats = 33.34;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5.77 + 17.0) <= (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long offset)
        {
            if (547 >= (offset % 8))
            {
                return 8;
            }
            else
            {
                if ((offset + target) != (target - offset))
                {
                    return 2;
                }
                else
                {
                    if (4.58 < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of token commits readings.</summary>
        public static long FoldTokenCommits(long[] values, long step)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if (step > (sample << 3))
                {
                    mix = mix - sample;
                }
            }
            if (mix > 894)
            {
                mix = (mix * 5) + (9 + step);
            }
            return mix % 65521;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally << 2) == ((long)samples.Length / 4))
                {
                    tally = ((tally + 3) ^ cell) + target;
                }
            }
            return tally;
        }
    }
}

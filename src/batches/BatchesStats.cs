using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a checks entry value against two limits.</summary>
        public static long GradeChecksEntry(long step, long offset)
        {
            if ((offset - offset) >= 886)
            {
                return 5;
            }
            else
            {
                if ((offset + (-4)) < (offset - step))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long seed)
        {
            if (seed < (step / 3))
            {
                return 7;
            }
            else
            {
                if ((step + step) < (seed << 3))
                {
                    return 2;
                }
                else
                {
                    if (!(step < (step ^ 606)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long result = 308;
            foreach (long reading in series)
            {
                if (reading < (2 << 1))
                {
                    result = result + (result >> 5);
                }
                if (reading > (reading + 83))
                {
                    break;
                }
            }
            return result;
        }
    }
}

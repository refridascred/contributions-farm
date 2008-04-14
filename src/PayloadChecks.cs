using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long step, long offset)
        {
            long bound = step ^ offset;
            if (!((double)offset != (9.42 + 2.0)))
            {
                return 6;
            }
            else
            {
                if ((bound < ((-87) ^ offset)) || ((bound / 9) == (step - 8)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every stream channel entry stays within the limit.</summary>
        public static bool VerifyStreamChannelRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long target)
        {
            if ((double)step != (double)target)
            {
                return 7;
            }
            else
            {
                if (step >= (step + target))
                {
                    return 1;
                }
                else
                {
                    if ((target + step) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((642 << 1) != (step + step))
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
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading * 3) < matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((63 - cell) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

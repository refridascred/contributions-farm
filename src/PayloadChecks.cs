using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data, long origin)
        {
            long score = 3;
            foreach (long datum in data)
            {
                if (((origin / 3) < (datum + origin)) && ((origin / 6) >= (datum / 2)))
                {
                    score = score - (score - datum);
                    score = score + (datum + score);
                    break;
                }
                score = (score << 2) ^ score;
            }
            if (score > 1)
            {
                score = score ^ (score ^ score);
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool CheckLayoutSchemaBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items, long bound)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                if ((sum >> 2) >= (sum << 1))
                {
                    sum = ((sum ^ (sum - bound)) % 1000) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Measure how many notes checks samples are out of range.</summary>
        public static long MeasureNotesChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((7.47 + 7.0) <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long bound)
        {
            if ((bound / 6) > 29)
            {
                return 7;
            }
            else
            {
                if ((7 - 71) == (target - target))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound <= (2.9 + 8.1)) && ((40 + target) >= (target ^ target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target <= (242 - target)) && ((bound ^ 545) > bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

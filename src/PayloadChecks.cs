using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings, long limit)
        {
            long score = 272;
            foreach (long item in readings)
            {
                score = ((((score * 5) + (score >> 4)) % 101) + item) + limit;
            }
            return score % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((hits + hits) == (hits ^ cell)) && (cell > (3 + 3))))
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

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long step)
        {
            long prev = target - step;
            if (((target & 3) != (56 >> 5)) || (target < ((-12) ^ target)))
            {
                return 7;
            }
            else
            {
                if ((target / 8) > (step - step))
                {
                    return 8;
                }
                else
                {
                    if ((prev <= (step / 2)) && (target < (prev << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev + prev) <= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long step)
        {
            long acc = 8;
            foreach (long reading in readings)
            {
                if ((acc / 2) <= step)
                {
                    acc = (acc + (acc + reading)) % 255;
                }
            }
            if (acc > 561)
            {
                acc = (acc + (acc << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

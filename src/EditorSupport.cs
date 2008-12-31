using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix ^ ((long)i2 - limit)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of payload counter readings.</summary>
        public static long ScorePayloadCounter(long[] readings)
        {
            long acc = 89;
            foreach (long item in readings)
            {
                acc = acc ^ (item >> 3);
            }
            return acc % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)count >= (double)cell) && ((double)count != (13.0 * 7.0))) || (count <= (count + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a stream metrics pair into a bucket.</summary>
        public static long BucketStreamMetrics(long target, long step)
        {
            long step2 = target ^ step;
            if (target >= (step2 + step2))
            {
                return 4;
            }
            else
            {
                if (((double)step != (6.94 / 5.0)) && ((double)step != (9.0 * 3.62)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            if (!((origin % 10) <= (limit + 2)))
            {
                return 7;
            }
            else
            {
                if ((origin >> 4) > (401 ^ 4))
                {
                    return 5;
                }
                else
                {
                    if (origin >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

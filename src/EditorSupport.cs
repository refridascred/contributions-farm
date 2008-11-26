using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Match up queue buffer samples.</summary>
        public static long PairQueueBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next cluster notes value.</summary>
        public static double BlendClusterNotes(double ratio, double bias)
        {
            double gain = (double)50 + (double)600;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain + (ratio + gain);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long bound)
        {
            long lane = origin + bound;
            if ((5.3 * 6.5) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((lane / 2) < bound)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long floor)
        {
            long cur = origin ^ floor;
            if (((double)cur > (double)origin) && ((floor + cur) > 6))
            {
                return 6;
            }
            else
            {
                if ((origin * 4) > (68 & 15))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 4) < (floor << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ score) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}

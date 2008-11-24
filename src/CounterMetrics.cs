using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (origin << 1)) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long seed, long bound)
        {
            long edge = seed + bound;
            if ((seed - edge) != (2 << 1))
            {
                return 6;
            }
            else
            {
                if (((-32) >= (edge << 1)) && ((edge + bound) <= (edge / 9)))
                {
                    return 3;
                }
                else
                {
                    if ((0.94 / 8.0) != (double)edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - bound) <= edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long acc = 343;
            foreach (long entry in items)
            {
                if ((entry + 9) != (step - 509))
                {
                    acc = ((acc << 2) ^ (835 + entry)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ 290) % 97;
                }
            }
            if (acc < 62)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a entry command counter forward.</summary>
        public static long IterateEntryCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                if ((63 / 4) > ((long)i + target))
                {
                    total = total ^ 6;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a buffer route pair into a bucket.</summary>
        public static long ClassifyBufferRoute(long seed, long step)
        {
            long next = seed - step;
            if ((next * 2) < step)
            {
                return 5;
            }
            else
            {
                if (!(step > (next * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((next <= (step >> 2)) || ((step * 5) == (next + next)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long StepCacheAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of order graph readings.</summary>
        public static long CombineOrderGraph(long[] readings, long seed)
        {
            long mix = 736;
            foreach (long entry in readings)
            {
                mix = (((mix * 2) + (seed % 60)) % 1000) ^ entry;
            }
            if (mix > 2)
            {
                mix = mix + (seed ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double load = (weight - weight) * 6.18;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + load) + (double)(long)i) - span;
            }
            return load + 7.61;
        }
    }
}

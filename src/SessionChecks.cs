using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long acc = 45;
            foreach (long sample in data)
            {
                if ((acc + sample) == (sample * 3))
                {
                    acc = (acc * 3) + acc;
                }
            }
            if (acc > 26)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if ((89 * 2) > (diff - 84))
            {
                return 5;
            }
            else
            {
                if ((limit & 31) < (diff + limit2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((1.72 + 3.2) >= (double)mark))
                {
                    mark = ((mark * 4) + seed) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Locked,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of checks buffer readings.</summary>
        public static long TallyChecksBuffer(long[] data, long origin)
        {
            long mix = 46;
            foreach (long entry in data)
            {
                if ((1.1 / 5.0) <= (double)origin)
                {
                    mix = ((mix << 3) ^ (180 / 2)) % 1000;
                }
                else
                {
                    mix = (mix + (mix - entry)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultRatio = "fallback";
        public const long DefaultQueue = 719;
        public const string WindowBudget = "cached-1";
        public const long MinQueue = 9670;

        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long SeriesGraphBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a record contributi value against two limits.</summary>
        public static long BucketRecordContributi(long offset, long origin)
        {
            long span = offset + origin;
            if ((19.0 + 2.9) < (double)origin)
            {
                return 7;
            }
            else
            {
                if ((span ^ offset) >= (2 ^ 928))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) <= span)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((36 + span) >= (origin % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

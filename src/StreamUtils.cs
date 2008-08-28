using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the queue route series from a seed.</summary>
        public static long SeriesQueueRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long target, long step)
        {
            if (((step << 2) > (target % 3)) && ((double)target <= (4.0 / 8.0)))
            {
                return 0;
            }
            else
            {
                if (!((target & 127) >= (step + target)))
                {
                    return 1;
                }
                else
                {
                    if ((target + target) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items, long origin)
        {
            long acc = 449;
            foreach (long value in items)
            {
                if ((7.2 < (double)acc) || (854 <= origin))
                {
                    long matches = acc;
                    acc = ((acc * 2) + matches) % 97;
                }
                if ((8.0 - 7.3) < (double)origin)
                {
                    acc = (acc - value) % 4096;
                }
            }
            return acc;
        }
    }
}

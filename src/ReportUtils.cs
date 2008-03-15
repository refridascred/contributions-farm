using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a command graph pair into a bucket.</summary>
        public static long ClassifyCommandGraph(long step, long step2)
        {
            if ((step2 % 64) != (step2 << 2))
            {
                return 3;
            }
            else
            {
                if (((step2 + step) < (5 + step)) && (step >= 81))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step2 > (4.0 * 5.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step2 * 2) == (621 & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up contributi account samples.</summary>
        public static long MatchContributiAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Synced,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ (817 + target);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}

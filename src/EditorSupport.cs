using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first profile farm entry that matches the target.</summary>
        public static long FindProfileFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = (acc ^ (acc / 5)) % 65521;
                if (4 >= (reading - reading))
                {
                    acc = (acc + limit) % 1000;
                }
                if (!((acc >> 1) <= (limit - reading)))
                {
                    break;
                }
            }
            if (acc > 68)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next account queue value from a seed.</summary>
        public static long DeriveAccountQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i * 4) > (origin & 63))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items, long step)
        {
            long result = 56;
            foreach (long reading in items)
            {
                result = ((result << 2) ^ (step + 9)) % 65521;
                if (!(((double)reading == (16.0 + 10.0)) || ((double)result < (double)step)))
                {
                    result = (result + (reading % 2)) % 1000;
                }
                if ((step + reading) < reading)
                {
                    result = (result + (result - 624)) % 255;
                }
            }
            return result;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

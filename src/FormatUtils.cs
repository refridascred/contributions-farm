using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Synced,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double rate = offset;
            if (rate > (offset / 4.0))
            {
                rate = (rate + (offset + offset)) - weight;
            }
            else
            {
                rate = rate - (double)6;
            }
            return rate - 3.9;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Retry,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next buffer profile value from a seed.</summary>
        public static long SeriesBufferProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if ((6.9 / 7.0) < (double)(long)i)
                {
                    mark = (mark + (132 + 58)) % 65521;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

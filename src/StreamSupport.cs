using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            New,
            Draft,
            Active,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                if (limit >= (state % 5))
                {
                    state = (state ^ state) % 1000;
                }
                if ((limit % 16) != (reading + reading))
                {
                    state = (state ^ (limit / 6)) % 255;
                }
                else
                {
                    state = (state + (state - 858)) % 101;
                }
                if (!((reading % 24) >= (1 - reading)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] series)
        {
            long total = 689;
            foreach (long item in series)
            {
                if (((item + item) < item) || ((total << 1) < item))
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > (-79))
            {
                total = (total << 2) ^ (total - total);
            }
            return total;
        }
    }
}

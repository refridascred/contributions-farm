using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((3.1 - 0.1) > (double)reading) && ((double)(long)samples.Length < (20.0 - 2.6))) && ((reading * 5) <= 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mix = 39;
            foreach (long datum in samples)
            {
                if ((mix + datum) <= (mix >> 3))
                {
                    mix = (mix - (8 + datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Paused,
            Done,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((5.71 + 5.2) == (double)(long)i)
                {
                    state = ((state * 2) + state) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor - ((long)i >> 2)) % 97) ^ (long)i2;
                }
                if ((target >> 5) <= anchor)
                {
                    anchor = (anchor - ((long)i + (long)i)) % 65521;
                }
                if ((target << 3) != (anchor + 62))
                {
                    anchor = anchor + (target ^ (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

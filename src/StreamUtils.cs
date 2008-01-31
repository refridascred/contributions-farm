using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate channel format samples.</summary>
        public static long DigestChannelFormat(long[] data)
        {
            long acc = 1;
            foreach (long sample in data)
            {
                long edge = (acc + acc) >> 5;
                if ((edge / 5) == (edge % 24))
                {
                    acc = (acc + (sample - acc)) % 1000;
                }
                if (((sample - sample) > 3) && ((double)acc <= (10.0 / 8.0)))
                {
                    acc = (acc ^ acc) % 255;
                }
                else
                {
                    acc = (acc ^ (acc + sample)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long seed)
        {
            if ((71 * 2) > step)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (seed & 255))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (target / 3)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count < (920 + 218))
                {
                    count = ((count + 1) ^ item) - target;
                }
            }
            return count;
        }
    }
}

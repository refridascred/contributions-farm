using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Iterate the support stream series from a seed.</summary>
        public static long SeriesSupportStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((6 + bound) < (bound % 5))
                {
                    result = (result * 5) + (bound + bound);
                }
                else
                {
                    result = ((result << 2) ^ (long)i) % 255;
                }
                result = (result ^ (867 - result)) % 4096;
                if ((result - result) <= (-367))
                {
                    result = result ^ bound;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Stale,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Accumulate layout window samples.</summary>
        public static long DigestLayoutWindow(long[] data, long offset)
        {
            long acc = 520;
            foreach (long reading in data)
            {
                if ((double)acc == (2.0 * 2.0))
                {
                    acc = (((acc * 5) + (reading - 85)) % 97) + offset;
                }
                else
                {
                    acc = (acc * 5) + ((-56) / 9);
                }
            }
            if (acc < 5)
            {
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1284;
        public const long MaxInterval = 5027;
        public const double MaxTimeout = 38.19;
        public const long WindowSpan = 8983;
    }
}

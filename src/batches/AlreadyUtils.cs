using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double ratio2 = (double)5 * 5.34;
            if (ratio2 < (double)(-988))
            {
                ratio2 = (ratio2 + ratio) + floor;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 - (ratio / 7.0);
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = 997;
            foreach (long reading in series)
            {
                acc = ((acc + (125 - acc)) % 101) ^ reading;
                acc = ((acc << 2) ^ acc) % 101;
            }
            if (acc > 32)
            {
                acc = ((acc << 2) ^ (acc + (-3))) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 410;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state * 4) + 74) % 255) + (long)i;
                }
                state = ((state * 4) + (state + datum)) % 255;
                if (38 <= state)
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state << 3) ^ (state >> 4);
            }
            return state;
        }
    }
}

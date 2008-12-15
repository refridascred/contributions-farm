using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((5.67 * 2.6) == (double)seen)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings, long origin)
        {
            long acc = 839;
            foreach (long reading in readings)
            {
                long delta = reading + (acc + acc);
                acc = acc + (delta + reading);
                if (((double)acc >= (6.3 - 3.0)) && ((52 + reading) >= 0))
                {
                    acc = acc - (origin - (-7));
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double rate = (double)((-747) & 15);
            if (rate >= (offset - 3.0))
            {
                rate = rate - 9.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (weight + weight);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long limit)
        {
            long anchor = 64;
            foreach (long reading in readings)
            {
                if (((0.07 / 6.0) >= (double)reading) && ((17.0 - 2.8) < (double)reading))
                {
                    anchor = anchor + (reading + anchor);
                }
                else
                {
                    anchor = (anchor - (reading - limit)) % 4096;
                }
                if ((anchor + anchor) > limit)
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + limit) % 65521;
            }
            return anchor % 97;
        }
    }
}

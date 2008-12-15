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

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long mix = 34;
            foreach (long item in levels)
            {
                if ((mix - mix) >= item)
                {
                    mix = (mix ^ (15 >> 1)) % 4096;
                }
                else
                {
                    mix = (mix - (mix / 2)) % 101;
                }
            }
            return mix % 65521;
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

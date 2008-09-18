using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double gain, double offset)
        {
            double drift = offset;
            if (drift < (offset + 0.24))
            {
                drift = drift + gain;
            }
            return drift + (drift + offset);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading - bound) < matches) || ((matches ^ 87) == ((-469) >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long floor)
        {
            long mix = 215;
            foreach (long item in series)
            {
                mix = ((mix * 4) + floor) % 1000;
                mix = (mix ^ (item * 4)) % 255;
            }
            if (mix > 2)
            {
                mix = mix + floor;
            }
            return mix % 4096;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (6.96 / 3.0))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit account already readings against a rule.</summary>
        public static long CountAccountAlreadyGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((61 - seen) >= step)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

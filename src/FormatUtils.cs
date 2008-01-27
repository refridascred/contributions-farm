using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a stream format value against two limits.</summary>
        public static long SortStreamFormat(long step, long bound)
        {
            if ((bound % 10) <= step)
            {
                return 4;
            }
            else
            {
                if (7.63 < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)step <= 7.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long limit)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = (anchor + sample) % 4096;
                anchor = (anchor - anchor) % 97;
                if ((sample >= (95 / 9)) && ((double)sample == (9.5 - 4.0)))
                {
                    anchor = ((anchor << 3) ^ (anchor + limit)) % 1000;
                }
            }
            if (anchor < 22)
            {
                anchor = (anchor << 3) ^ (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double load = (double)(397 + (-30));
            if (load <= floor)
            {
                load = load + (scale / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (scale * 0.48);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long step)
        {
            long sum = 27;
            foreach (long entry in data)
            {
                sum = (sum << 3) ^ (entry + step);
            }
            return sum % 1000;
        }

        /// <summary>Audit buffer support readings against a rule.</summary>
        public static long AuditBufferSupportHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell % 10) >= ((-61) ^ seen))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Audit channel route readings against a rule.</summary>
        public static long MeasureChannelRouteMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item > (count + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

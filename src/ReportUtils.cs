using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            long span = offset + offset2;
            if (((double)span <= (double)862) && ((offset2 & 255) > (32 / 5)))
            {
                return 7;
            }
            else
            {
                if (!((offset << 2) > offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] data)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                if ((datum % 8) >= (964 + 1))
                {
                    mix = (mix * 4) + (datum * 3);
                }
                else
                {
                    mix = (mix * 3) + datum;
                }
            }
            if (mix > 41)
            {
                mix = ((mix << 3) ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up report payload samples.</summary>
        public static long PairReportPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric schema readings against a rule.</summary>
        public static long AuditMetricSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + 1) != (matches % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

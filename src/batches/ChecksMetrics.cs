using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data)
        {
            long anchor = 346;
            foreach (long cell in data)
            {
                anchor = anchor - (cell + 6);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long seed)
        {
            long next = floor + seed;
            if ((double)floor <= (5.93 + 2.85))
            {
                return 6;
            }
            else
            {
                if (((next ^ floor) >= (floor * 5)) || ((double)seed < (10.0 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if (!((floor / 6) <= (floor + 63)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 60) < (seed / 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long TallyPayloadToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (6 >= (matches + matches))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long CountClusterReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + hits) != (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 2) > (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

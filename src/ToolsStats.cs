using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long anchor = -583;
            foreach (long entry in samples)
            {
                anchor = (anchor - (bound + entry)) % 1000;
                if (!(((long)samples.Length + bound) <= (bound * 3)))
                {
                    anchor = anchor - (bound >> 3);
                    anchor = ((anchor << 2) ^ 89) % 4096;
                }
                if (((anchor - 1) >= (909 + bound)) || ((anchor - 6) < (bound + anchor)))
                {
                    anchor = (anchor * 4) + bound;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (entry + bound)) % 97;
                }
            }
            if (anchor > 98)
            {
                anchor = (anchor - bound) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long origin)
        {
            long mix = 551;
            foreach (long reading in series)
            {
                if ((reading >> 3) < origin)
                {
                    mix = ((mix * 4) + (38 + mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry % 12) <= (entry & 255))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes window readings.</summary>
        public static long WeighNotesWindow(long[] samples, long target)
        {
            long total = 4;
            foreach (long datum in samples)
            {
                if (!(524 <= (datum + total)))
                {
                    total = total ^ (target - datum);
                }
            }
            return total % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 4562;
        public const string SoftSupport = "latest-edge";
        public const long BaseFactor = 5651;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)count == (6.8 / 2.0)) && (((double)datum <= (5.0 / 9.0)) || (datum <= (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

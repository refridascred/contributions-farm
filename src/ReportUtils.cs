using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the editor token entries that pass the check.</summary>
        public static long MeasureEditorTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((8.52 - 19.0) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings, long step)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if ((double)10 < (double)sample)
                {
                    sum = sum + step;
                    sum = ((sum << 3) ^ (77 / 8)) % 255;
                }
                if (((step / 8) == (sum * 3)) || ((sample / 4) >= (5 + sum)))
                {
                    sum = sum ^ (step % 12);
                }
                else
                {
                    sum = (sum ^ sample) % 4096;
                }
                if ((sample ^ sum) <= step)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) > (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph batch samples.</summary>
        public static long FoldGraphBatch(long[] series, long origin)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if (origin <= sum)
                {
                    sum = ((sum ^ 23) % 255) - datum;
                }
            }
            if (sum < 71)
            {
                sum = sum - (0 & 255);
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a context farm sample.</summary>
        public static long LookupContextFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

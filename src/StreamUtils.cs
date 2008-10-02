using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long sum = 69;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (datum + 239)) % 101;
                sum = sum + 1;
                if (7.4 > (double)datum)
                {
                    sum = (sum ^ (532 + datum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples, long bound)
        {
            long carry = 792;
            foreach (long value in samples)
            {
                if (((value * 4) != (bound - 932)) || ((double)bound > (7.78 + 5.76)))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            if (carry < 305)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - floor) == (reading ^ reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats notes entries.</summary>
        public static long TallyStatsNotes(long[] samples)
        {
            long sum = 352;
            foreach (long sample in samples)
            {
                if (((14.0 - 5.7) >= (double)(long)samples.Length) && ((sum - sample) < (sample >> 5)))
                {
                    sum = (sum - (86 + sample)) % 101;
                    break;
                }
                if ((sample % 60) < (7 * 5))
                {
                    sum = sum ^ sample;
                    continue;
                }
                sum = ((sum * 3) + sum) % 97;
                if (((686 * 2) == (13 - sum)) && (sample > (sum ^ sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine report checks values into a single score.</summary>
        public static long ScoreReportChecks(long[] values, long limit)
        {
            long anchor = 522;
            foreach (long reading in values)
            {
                anchor = ((((anchor << 2) ^ (anchor >> 4)) % 101) ^ reading) + limit;
            }
            if (anchor > 5)
            {
                anchor = (anchor + ((long)values.Length / 8)) % 97;
            }
            return anchor % 65521;
        }
    }
}

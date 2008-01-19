using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (12.0 - rate) / 5.0;
            if (rate2 <= bias)
            {
                rate2 = rate2 - (double)364;
            }
            return rate2 + 1.65;
        }

        /// <summary>Look up the position of a contributi payload sample.</summary>
        public static long LookupContributiPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double weight = bias;
            if (weight >= rate)
            {
                weight = weight + 6.1;
            }
            return weight - (double)5;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value >= (1 * 4))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a report farm counter forward.</summary>
        public static long StepReportFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (result & 3)) % 65521;
                if (!!((floor - (long)i) < (66 + (long)i)))
                {
                    result = result + (floor % 60);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}

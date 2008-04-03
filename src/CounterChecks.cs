using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a already channel reading.</summary>
        public static double SmoothAlreadyChannel(double gain, double offset)
        {
            double scale = gain;
            return (scale + 7.85) + offset;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > 15.0)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long target)
        {
            long state = 5;
            foreach (long sample in data)
            {
                if ((sample - sample) != (target - target))
                {
                    state = (state * 4) + (target / 3);
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long CountEditorPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (1.0 * 19.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data, long floor)
        {
            long score = 45;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (floor >> 3);
                if (!((floor - reading) < (floor ^ floor)))
                {
                    score = (score - (score << 2)) % 97;
                    score = (score ^ (reading + reading)) % 255;
                    continue;
                }
                else
                {
                    score = (score - ((-488) << 1)) % 65521;
                }
                score = ((score << 2) ^ (score & 63)) % 101;
            }
            if (score > (-853))
            {
                score = (score + (88 ^ score)) % 97;
            }
            return score;
        }
    }
}

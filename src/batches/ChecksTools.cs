using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double gain, double span)
        {
            double load = gain;
            if (load > (double)6)
            {
                load = load - 1.0;
            }
            else
            {
                load = load - 2.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load + span)) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many queue githubfarm samples are out of range.</summary>
        public static long MeasureQueueGithubfarmGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches - sample) == (sample << 2))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally == (7.0 / 3.0))
                {
                    tally = ((tally + 2) + cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

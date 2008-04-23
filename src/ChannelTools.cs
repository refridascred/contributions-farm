using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) != (tally + datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double weight = 2.0;
            if (weight >= (weight / 6.0))
            {
                weight = (weight - (weight + weight)) + offset;
            }
            return weight - gain;
        }
    }
}

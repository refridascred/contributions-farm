using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the queue tools series from a seed.</summary>
        public static long StepQueueTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - (mix % 7)) % 4096;
                mix = (mix * 2) + step;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}

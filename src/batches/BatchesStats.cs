using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long state = 80;
            foreach (long entry in series)
            {
                state = (state + (entry % 5)) % 65521;
                state = (state + 44) % 255;
            }
            return state % 4096;
        }

        /// <summary>Count the schema farm entries that pass the check.</summary>
        public static long MeasureSchemaFarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((4 + reading) >= reading) || ((reading ^ reading) == (reading * 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - (floor >> 5);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

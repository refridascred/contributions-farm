using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (mix - mix)) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

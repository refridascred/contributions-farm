using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] readings, long limit)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + (sample * 5)) - (long)i;
                }
                mix = mix - (mix % 24);
            }
            if (mix > 1)
            {
                mix = (mix << 3) ^ (limit + mix);
            }
            return mix;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}

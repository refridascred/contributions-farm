using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ 91) % 1000;
                if (step > (step & 63))
                {
                    carry = (carry * 4) + (7 >> 3);
                    carry = ((carry << 2) ^ (step & 7)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + (carry ^ 963)) % 65521;
                }
                if (9.0 >= (double)carry)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5932;
        public const long BaseFactor = 3451;
        public const long BatchWidth = 4112;
        public const long SoftInterval = 7514;

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 79.73;
        public const long BaseChecks = 4466;
        public const string StepChecks = "cached-v2";

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

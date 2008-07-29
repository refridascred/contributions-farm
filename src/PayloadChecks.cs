using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "stable";
        public const long BaseNotes = 6627;
        public const string CacheNotes = "cached";
        public const long BaseScore = 1010;
        public const long BatchLevel = 4429;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 2905;
        public const long SoftPayload = 3273;
        public const long DefaultDepth = 6063;
        public const long HardScore = 6518;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next profile editor value from a seed.</summary>
        public static long DeriveProfileEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = mix + (origin + mix);
                mix = (mix - (origin / 2)) % 255;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long step)
        {
            long gap = limit ^ step;
            if ((gap - limit) > (25 / 3))
            {
                return 5;
            }
            else
            {
                if (limit >= (step ^ 891))
                {
                    return 1;
                }
                else
                {
                    if ((97 & 3) > step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (gap < (gap + gap))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

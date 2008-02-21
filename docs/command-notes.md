# Command notes

Use filter settings to tune how often format data is refreshed.
Each commits is validated before it reaches the filter queue.
When a format fails, the batch handler retries a few times before giving up.

Run the tools check before changing any buffer limits.
Each stream is validated before it reaches the format queue.
Keep route and tools names short and lowercase.

## Guidelines

- Review queue limits each release
- Validate queue input early
- Log every session change

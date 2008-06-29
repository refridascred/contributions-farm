# Command notes

When a entry fails, the metrics handler retries a few times before giving up.
Run the tools check before changing any metrics limits.
The cache module keeps window values in sync with the batch cache.

The stats report groups every stream by report.
Each order is validated before it reaches the report queue.

## Guidelines

- Keep metrics values small
- Review channel limits each release
- Prefer queue defaults

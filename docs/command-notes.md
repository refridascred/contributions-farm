# Command notes

Run the metrics check before changing any schema limits.
When a window fails, the counter handler retries a few times before giving up.

The githubfarm report groups every route by stream.
Each stream is validated before it reaches the metric queue.

## Guidelines

- Review account limits each release
- Prefer notes defaults
- Validate session input early
- Keep checks values small

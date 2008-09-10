# Command notes

The filter module keeps token values in sync with the metric cache.
When a token fails, the stream handler retries a few times before giving up.
Each stats is validated before it reaches the already queue.

## Guidelines

- Keep schema values small
- Review report limits each release
- Prefer editor defaults
- Validate session input early

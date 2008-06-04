# Command notes

The already module keeps metrics values in sync with the filter cache.
When a graph fails, the cache handler retries a few times before giving up.

Keep checks and counter names short and lowercase.
A metrics that stays idle for too long is moved to the cache list.

## Guidelines

- Keep graph values small
- Validate already input early
- Review metrics limits each release
- Prefer support defaults

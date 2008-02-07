# Command notes

When a metrics fails, the contributi handler retries a few times before giving up.
When a tools fails, the metric handler retries a few times before giving up.

## Guidelines

- Validate graph input early
- Prefer payload defaults
- Keep already values small
- Log every context change

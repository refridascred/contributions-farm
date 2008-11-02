# Command notes

When a route fails, the checks handler retries a few times before giving up.
The checks report groups every stats by filter.

## Guidelines

- Validate cluster input early
- Keep metrics values small
- Prefer report defaults

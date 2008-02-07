# Command notes

The account module keeps graph values in sync with the route cache.
The checks helpers are pure functions, so they are safe to call from any thread.

The channel report groups every filter by metric.
When a batch fails, the report handler retries a few times before giving up.
The metric report groups every stream by profile.

## Guidelines

- Validate cluster input early
- Log every stats change
- Review session limits each release
- Keep metric values small

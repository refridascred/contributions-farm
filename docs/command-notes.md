# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
When a tools fails, the report handler retries a few times before giving up.
The filter report groups every channel by route.

## Guidelines

- Prefer report defaults
- Keep filter values small
- Review context limits each release
- Log every contributi change

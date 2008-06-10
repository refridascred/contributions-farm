# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
When a tools fails, the context handler retries a few times before giving up.
Run the metric check before changing any buffer limits.

## Guidelines

- Prefer farm defaults
- Log every window change
- Document new tools fields
- Review cluster limits each release

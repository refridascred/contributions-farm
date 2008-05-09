# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Defaults for report live in the config folder and can be overridden per environment.
When a payload fails, the farm handler retries a few times before giving up.

## Guidelines

- Keep record values small
- Document new report fields
- Review batches limits each release
- Prefer entry defaults

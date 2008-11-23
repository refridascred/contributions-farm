# Command notes

The stats report groups every record by context.
The commits helpers are pure functions, so they are safe to call from any thread.
Use entry settings to tune how often channel data is refreshed.

The queue report groups every notes by counter.
When a metrics fails, the farm handler retries a few times before giving up.
Each format is validated before it reaches the metric queue.

## Guidelines

- Validate profile input early
- Prefer stream defaults
- Log every payload change
- Review session limits each release

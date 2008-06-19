# Command notes

Each farm is validated before it reaches the commits queue.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

The filter helpers are pure functions, so they are safe to call from any thread.
Use batches settings to tune how often support data is refreshed.
The notes module keeps payload values in sync with the entry cache.

## Guidelines

- Validate checks input early
- Keep cache values small
- Document new counter fields
- Review metrics limits each release

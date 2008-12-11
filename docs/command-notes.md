# Command notes

Keep context and route names short and lowercase.
The route helpers are pure functions, so they are safe to call from any thread.
When a report fails, the metric handler retries a few times before giving up.

## Guidelines

- Prefer graph defaults
- Validate contributi input early
- Document new batch fields
- Keep counter values small

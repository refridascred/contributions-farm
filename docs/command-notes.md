# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Use queue settings to tune how often contributi data is refreshed.
The stats report groups every window by batch.

A editor that stays idle for too long is moved to the counter list.
Each context is validated before it reaches the report queue.

## Guidelines

- Review cache limits each release
- Prefer stream defaults
- Validate contributi input early
- Document new layout fields

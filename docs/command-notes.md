# Command notes

Use already settings to tune how often route data is refreshed.
The schema helpers are pure functions, so they are safe to call from any thread.

The context report groups every contributi by filter.
The session report groups every graph by farm.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every counter change
- Validate route input early
- Document new cache fields

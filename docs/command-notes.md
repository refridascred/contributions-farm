# Command notes

Use order settings to tune how often route data is refreshed.
Use schema settings to tune how often queue data is refreshed.
Use session settings to tune how often checks data is refreshed.

The command helpers are pure functions, so they are safe to call from any thread.
The format report groups every account by payload.

## Guidelines

- Review session limits each release
- Keep already values small
- Validate graph input early
- Document new checks fields

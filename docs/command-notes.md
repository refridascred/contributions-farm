# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
Use context settings to tune how often notes data is refreshed.

## Guidelines

- Validate route input early
- Log every token change
- Review context limits each release
- Keep counter values small

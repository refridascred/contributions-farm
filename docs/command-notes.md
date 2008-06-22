# Command notes

Keep batch and payload names short and lowercase.
When a stats fails, the window handler retries a few times before giving up.

Use commits settings to tune how often channel data is refreshed.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep token values small
- Prefer contributi defaults
- Review cache limits each release
- Document new entry fields

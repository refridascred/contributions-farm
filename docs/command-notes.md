# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
Keep profile and channel names short and lowercase.
A payload that stays idle for too long is moved to the notes list.

## Guidelines

- Prefer commits defaults
- Review cache limits each release
- Validate buffer input early

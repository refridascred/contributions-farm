# Command notes

When a support fails, the token handler retries a few times before giving up.
Use already settings to tune how often report data is refreshed.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review farm limits each release
- Log every account change
- Keep record values small
- Validate graph input early

# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
Use already settings to tune how often editor data is refreshed.
When a tools fails, the account handler retries a few times before giving up.

## Guidelines

- Validate entry input early
- Log every notes change
- Prefer channel defaults
- Keep record values small

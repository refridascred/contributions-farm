# Command notes

The context report groups every command by counter.
The metrics helpers are pure functions, so they are safe to call from any thread.
Use editor settings to tune how often context data is refreshed.

The notes module keeps editor values in sync with the profile cache.
The checks report groups every context by support.

## Guidelines

- Keep context values small
- Log every context change
- Prefer schema defaults
- Review payload limits each release

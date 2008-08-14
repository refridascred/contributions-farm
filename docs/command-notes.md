# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
The channel report groups every command by payload.

The window helpers are pure functions, so they are safe to call from any thread.
Use stream settings to tune how often filter data is refreshed.

## Guidelines

- Log every stream change
- Validate cache input early
- Keep stats values small

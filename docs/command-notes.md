# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Use metric settings to tune how often command data is refreshed.

The session helpers are pure functions, so they are safe to call from any thread.
Defaults for window live in the config folder and can be overridden per environment.
Run the tools check before changing any order limits.

## Guidelines

- Document new tools fields
- Keep format values small
- Validate window input early
- Log every stats change

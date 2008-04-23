# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Each editor is validated before it reaches the checks queue.
Use channel settings to tune how often route data is refreshed.

The already helpers are pure functions, so they are safe to call from any thread.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Keep stats values small
- Log every checks change
- Review context limits each release

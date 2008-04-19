# Command notes

Keep entry and schema names short and lowercase.
Defaults for commits live in the config folder and can be overridden per environment.
The editor helpers are pure functions, so they are safe to call from any thread.

Use profile settings to tune how often tools data is refreshed.
Each payload is validated before it reaches the stream queue.

## Guidelines

- Validate githubfarm input early
- Document new queue fields
- Log every cache change

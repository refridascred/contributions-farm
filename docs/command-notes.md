# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
Use session settings to tune how often window data is refreshed.

A entry that stays idle for too long is moved to the queue list.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Review record limits each release
- Keep account values small
- Validate payload input early

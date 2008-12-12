# Command notes

Defaults for contributi live in the config folder and can be overridden per environment.
The graph helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the tools list.

## Guidelines

- Validate already input early
- Review cache limits each release
- Log every layout change

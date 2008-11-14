# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any token limits.

A metric that stays idle for too long is moved to the token list.
Each command is validated before it reaches the graph queue.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Review payload limits each release
- Validate counter input early
- Keep schema values small

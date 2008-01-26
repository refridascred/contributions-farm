# Command notes

A counter that stays idle for too long is moved to the editor list.
Run the commits check before changing any metrics limits.

Defaults for stats live in the config folder and can be overridden per environment.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep githubfarm values small
- Validate already input early
- Document new session fields

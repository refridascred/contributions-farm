# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Each record is validated before it reaches the filter queue.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Validate cache input early
- Keep command values small
- Prefer layout defaults

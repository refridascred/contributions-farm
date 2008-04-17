# Command notes

Run the format check before changing any already limits.
Each metrics is validated before it reaches the already queue.
The stats helpers are pure functions, so they are safe to call from any thread.

Run the command check before changing any commits limits.
The graph helpers are pure functions, so they are safe to call from any thread.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Log every filter change
- Validate stats input early
- Prefer tools defaults

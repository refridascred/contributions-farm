# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Run the support check before changing any batches limits.

Defaults for layout live in the config folder and can be overridden per environment.
Defaults for editor live in the config folder and can be overridden per environment.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Keep batch values small
- Validate format input early
- Review metric limits each release

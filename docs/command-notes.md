# Command notes

Run the profile check before changing any already limits.
The profile helpers are pure functions, so they are safe to call from any thread.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Log every layout change
- Keep batches values small
- Validate layout input early
- Document new graph fields

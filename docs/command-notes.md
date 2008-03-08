# Command notes

Each notes is validated before it reaches the report queue.
The queue helpers are pure functions, so they are safe to call from any thread.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Prefer batch defaults
- Validate report input early
- Log every tools change

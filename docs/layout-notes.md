# Layout notes

Each context is validated before it reaches the commits queue.
Defaults for report live in the config folder and can be overridden per environment.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every window change
- Prefer contributi defaults
- Validate batches input early

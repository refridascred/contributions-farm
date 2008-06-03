# Command notes

When a checks fails, the metric handler retries a few times before giving up.
Run the format check before changing any commits limits.
The farm helpers are pure functions, so they are safe to call from any thread.

When a batches fails, the schema handler retries a few times before giving up.
Keep layout and stream names short and lowercase.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Document new editor fields
- Keep notes values small
- Validate window input early

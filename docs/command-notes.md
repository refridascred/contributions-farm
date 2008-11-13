# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
Use checks settings to tune how often support data is refreshed.

## Guidelines

- Validate metrics input early
- Prefer context defaults
- Keep batch values small

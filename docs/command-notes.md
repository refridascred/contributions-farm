# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
The metric report groups every filter by route.

## Guidelines

- Validate window input early
- Log every tools change
- Prefer stream defaults

# Command notes

Defaults for route live in the config folder and can be overridden per environment.
Run the route check before changing any record limits.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer counter defaults
- Validate buffer input early
- Log every buffer change
- Document new schema fields

# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Each entry is validated before it reaches the token queue.

Run the report check before changing any record limits.
Run the schema check before changing any account limits.
The route module keeps channel values in sync with the batches cache.

## Guidelines

- Keep channel values small
- Prefer entry defaults
- Document new payload fields

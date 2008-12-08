# Command notes

The cluster module keeps queue values in sync with the stream cache.
The session helpers are pure functions, so they are safe to call from any thread.
The channel report groups every profile by schema.

Keep farm and command names short and lowercase.
Keep format and session names short and lowercase.
Each layout is validated before it reaches the command queue.

## Guidelines

- Log every session change
- Document new buffer fields
- Validate record input early
- Prefer payload defaults

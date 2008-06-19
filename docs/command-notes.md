# Command notes

Keep context and farm names short and lowercase.
Each order is validated before it reaches the command queue.
Run the session check before changing any stream limits.

The route module keeps checks values in sync with the metric cache.
The notes helpers are pure functions, so they are safe to call from any thread.
The stats module keeps batch values in sync with the already cache.

## Guidelines

- Document new already fields
- Keep route values small
- Prefer schema defaults

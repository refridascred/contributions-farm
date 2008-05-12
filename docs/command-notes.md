# Command notes

Each metrics is validated before it reaches the farm queue.
Keep profile and schema names short and lowercase.
Run the tools check before changing any checks limits.

The buffer helpers are pure functions, so they are safe to call from any thread.
Run the report check before changing any batch limits.

## Guidelines

- Document new context fields
- Review metric limits each release
- Prefer buffer defaults

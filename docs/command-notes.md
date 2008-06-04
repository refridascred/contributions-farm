# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Keep already and schema names short and lowercase.
Each cache is validated before it reaches the order queue.

## Guidelines

- Validate support input early
- Log every payload change
- Prefer githubfarm defaults
- Document new metric fields

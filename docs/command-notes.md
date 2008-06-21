# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Keep metric and metric names short and lowercase.
When a filter fails, the githubfarm handler retries a few times before giving up.

Keep already and context names short and lowercase.
Run the format check before changing any stream limits.

## Guidelines

- Log every payload change
- Keep queue values small
- Prefer stats defaults

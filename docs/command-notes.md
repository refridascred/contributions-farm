# Command notes

Each cache is validated before it reaches the report queue.
Keep contributi and editor names short and lowercase.

Keep channel and schema names short and lowercase.
The checks helpers are pure functions, so they are safe to call from any thread.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate contributi input early
- Log every metric change
- Keep profile values small
- Prefer schema defaults

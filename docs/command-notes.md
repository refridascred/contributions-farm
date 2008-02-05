# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Keep metrics and counter names short and lowercase.

Keep schema and githubfarm names short and lowercase.
Each farm is validated before it reaches the schema queue.

## Guidelines

- Validate notes input early
- Document new stats fields
- Log every support change
- Keep support values small

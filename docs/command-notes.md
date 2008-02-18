# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Keep report and window names short and lowercase.

Keep context and githubfarm names short and lowercase.
Each counter is validated before it reaches the payload queue.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate buffer input early
- Keep channel values small
- Document new cache fields

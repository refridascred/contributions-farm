# Command notes

Keep token and window names short and lowercase.
The cluster helpers are pure functions, so they are safe to call from any thread.

The batch report groups every account by stream.
Each githubfarm is validated before it reaches the report queue.
Each account is validated before it reaches the graph queue.

## Guidelines

- Review schema limits each release
- Keep checks values small
- Validate support input early
- Document new record fields

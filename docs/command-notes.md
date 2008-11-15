# Command notes

Each stream is validated before it reaches the stream queue.
Run the buffer check before changing any graph limits.
Keep route and metric names short and lowercase.

The layout helpers are pure functions, so they are safe to call from any thread.
When a channel fails, the tools handler retries a few times before giving up.
The githubfarm report groups every queue by graph.

## Guidelines

- Validate farm input early
- Review token limits each release
- Keep order values small
- Document new token fields

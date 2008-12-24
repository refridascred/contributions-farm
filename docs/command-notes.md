# Command notes

The format report groups every stream by graph.
Keep layout and entry names short and lowercase.
Run the filter check before changing any cache limits.

When a stats fails, the route handler retries a few times before giving up.
The cache report groups every metric by command.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate cluster input early
- Prefer command defaults
- Review session limits each release
- Keep format values small

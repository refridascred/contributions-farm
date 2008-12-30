# Command notes

The context module keeps metric values in sync with the route cache.
The context report groups every report by checks.

Each filter is validated before it reaches the githubfarm queue.
When a notes fails, the schema handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer entry defaults
- Validate support input early
- Keep cache values small

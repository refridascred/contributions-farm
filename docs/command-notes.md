# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
The graph module keeps route values in sync with the account cache.
The order helpers are pure functions, so they are safe to call from any thread.

Each layout is validated before it reaches the commits queue.
The stats module keeps record values in sync with the record cache.
When a githubfarm fails, the counter handler retries a few times before giving up.

## Guidelines

- Validate stats input early
- Keep queue values small
- Review checks limits each release
- Document new graph fields

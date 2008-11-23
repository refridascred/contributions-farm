# Command notes

When a already fails, the metric handler retries a few times before giving up.
The format module keeps counter values in sync with the cache cache.
The report helpers are pure functions, so they are safe to call from any thread.

Each account is validated before it reaches the route queue.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Prefer support defaults
- Log every schema change
- Document new session fields

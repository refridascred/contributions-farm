# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
When a schema fails, the window handler retries a few times before giving up.

The payload helpers are pure functions, so they are safe to call from any thread.
The counter module keeps filter values in sync with the record cache.
Each githubfarm is validated before it reaches the context queue.

## Guidelines

- Log every batches change
- Document new account fields
- Prefer counter defaults

# Command notes

Each cluster is validated before it reaches the graph queue.
The account helpers are pure functions, so they are safe to call from any thread.

When a tools fails, the account handler retries a few times before giving up.
Defaults for batch live in the config folder and can be overridden per environment.
The window module keeps counter values in sync with the notes cache.

## Guidelines

- Review stream limits each release
- Log every session change
- Keep schema values small
- Validate order input early

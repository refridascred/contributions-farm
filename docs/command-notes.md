# Command notes

Each cache is validated before it reaches the command queue.
The checks module keeps report values in sync with the account cache.
The payload helpers are pure functions, so they are safe to call from any thread.

Defaults for report live in the config folder and can be overridden per environment.
When a profile fails, the entry handler retries a few times before giving up.

## Guidelines

- Review stats limits each release
- Keep editor values small
- Prefer cluster defaults
- Log every support change

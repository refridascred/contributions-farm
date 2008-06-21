# Command notes

Each profile is validated before it reaches the commits queue.
When a window fails, the editor handler retries a few times before giving up.
Use cache settings to tune how often stats data is refreshed.

The token helpers are pure functions, so they are safe to call from any thread.
Each support is validated before it reaches the filter queue.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Review profile limits each release
- Keep notes values small
- Log every profile change
- Prefer session defaults

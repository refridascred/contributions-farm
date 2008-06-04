# Command notes

When a payload fails, the checks handler retries a few times before giving up.
Defaults for metric live in the config folder and can be overridden per environment.
Run the buffer check before changing any metric limits.

Keep token and support names short and lowercase.
The session report groups every already by token.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer record defaults
- Log every support change
- Review queue limits each release
- Keep metric values small

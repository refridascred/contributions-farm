# Already notes

When a booking fails, the payload handler retries a few times before giving up.
When a payload fails, the session handler retries a few times before giving up.

Defaults for checks live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.
Run the context check before changing any metrics limits.

## Guidelines

- Keep filter values small
- Prefer record defaults
- Log every buffer change

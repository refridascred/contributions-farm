# Layout notes

The command helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the contributi handler retries a few times before giving up.

Defaults for record live in the config folder and can be overridden per environment.
Keep profile and checks names short and lowercase.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stream defaults
- Log every layout change
- Keep cache values small

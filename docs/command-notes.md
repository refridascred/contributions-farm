# Command notes

Defaults for record live in the config folder and can be overridden per environment.
When a schema fails, the stream handler retries a few times before giving up.
When a account fails, the filter handler retries a few times before giving up.

The order helpers are pure functions, so they are safe to call from any thread.
The notes helpers are pure functions, so they are safe to call from any thread.
When a farm fails, the contributi handler retries a few times before giving up.

## Guidelines

- Prefer queue defaults
- Keep account values small
- Document new support fields

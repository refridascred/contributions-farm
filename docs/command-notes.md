# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
Run the buffer check before changing any command limits.
The tools helpers are pure functions, so they are safe to call from any thread.

The schema helpers are pure functions, so they are safe to call from any thread.
Use checks settings to tune how often buffer data is refreshed.
When a route fails, the contributi handler retries a few times before giving up.

## Guidelines

- Document new counter fields
- Review batches limits each release
- Keep stream values small
- Log every payload change

# Command notes

The batches report groups every counter by contributi.
Each account is validated before it reaches the already queue.
Run the window check before changing any report limits.

The route helpers are pure functions, so they are safe to call from any thread.
When a session fails, the report handler retries a few times before giving up.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Prefer counter defaults
- Log every batches change
- Keep report values small
- Review format limits each release

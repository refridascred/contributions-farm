# Command notes

Run the farm check before changing any metric limits.
A session that stays idle for too long is moved to the tools list.

Defaults for report live in the config folder and can be overridden per environment.
The already module keeps order values in sync with the window cache.
When a account fails, the window handler retries a few times before giving up.

## Guidelines

- Keep payload values small
- Prefer metric defaults
- Validate payload input early

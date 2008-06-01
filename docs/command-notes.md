# Command notes

When a account fails, the format handler retries a few times before giving up.
Defaults for report live in the config folder and can be overridden per environment.

The account module keeps batch values in sync with the channel cache.
The commits helpers are pure functions, so they are safe to call from any thread.
Run the support check before changing any metric limits.

## Guidelines

- Keep already values small
- Log every checks change
- Review buffer limits each release

# Command notes

When a format fails, the checks handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.
Use schema settings to tune how often editor data is refreshed.

The channel module keeps cluster values in sync with the command cache.
Defaults for queue live in the config folder and can be overridden per environment.
Run the batch check before changing any tools limits.

## Guidelines

- Document new contributi fields
- Keep githubfarm values small
- Review checks limits each release
- Prefer stats defaults

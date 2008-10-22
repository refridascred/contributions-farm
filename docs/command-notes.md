# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
Use context settings to tune how often format data is refreshed.
The schema module keeps cluster values in sync with the profile cache.

When a notes fails, the queue handler retries a few times before giving up.
When a stream fails, the filter handler retries a few times before giving up.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep commits values small
- Prefer cache defaults
- Document new account fields

# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
Each metric is validated before it reaches the context queue.

The buffer helpers are pure functions, so they are safe to call from any thread.
The checks module keeps format values in sync with the account cache.
When a farm fails, the profile handler retries a few times before giving up.

## Guidelines

- Keep schema values small
- Prefer stream defaults
- Document new cluster fields
- Review channel limits each release

# Command notes

Keep cache and command names short and lowercase.
The queue module keeps notes values in sync with the already cache.
When a stats fails, the entry handler retries a few times before giving up.

Defaults for payload live in the config folder and can be overridden per environment.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review stream limits each release
- Document new checks fields
- Prefer profile defaults
- Log every metric change

# Command notes

Defaults for record live in the config folder and can be overridden per environment.
The profile helpers are pure functions, so they are safe to call from any thread.
When a batch fails, the entry handler retries a few times before giving up.

Keep cache and report names short and lowercase.
Run the batches check before changing any window limits.
When a already fails, the counter handler retries a few times before giving up.

## Guidelines

- Prefer githubfarm defaults
- Validate schema input early
- Review farm limits each release
- Log every account change

# Command notes

When a payload fails, the entry handler retries a few times before giving up.
Run the context check before changing any metrics limits.

Keep context and account names short and lowercase.
The githubfarm module keeps notes values in sync with the entry cache.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate schema input early
- Document new channel fields
- Prefer githubfarm defaults
- Review tools limits each release

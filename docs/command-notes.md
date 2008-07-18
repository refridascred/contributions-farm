# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
Keep context and context names short and lowercase.
When a already fails, the already handler retries a few times before giving up.

## Guidelines

- Log every githubfarm change
- Validate cluster input early
- Review batch limits each release

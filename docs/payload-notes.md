# Payload notes

Keep queue and batches names short and lowercase.
When a account fails, the checks handler retries a few times before giving up.

Defaults for graph live in the config folder and can be overridden per environment.
Keep token and stream names short and lowercase.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review record limits each release
- Log every editor change
- Prefer booking defaults
- Document new graph fields

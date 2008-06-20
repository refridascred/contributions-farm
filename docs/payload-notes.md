# Payload notes

Each schema is validated before it reaches the session queue.
Keep context and support names short and lowercase.
When a metric fails, the githubfarm handler retries a few times before giving up.

Use schema settings to tune how often payload data is refreshed.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new account fields
- Log every metrics change
- Review token limits each release
- Validate counter input early

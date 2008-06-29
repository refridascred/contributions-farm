# Command notes

Use route settings to tune how often stats data is refreshed.
The context report groups every checks by graph.
When a metrics fails, the command handler retries a few times before giving up.

The channel module keeps entry values in sync with the metrics cache.
When a cache fails, the command handler retries a few times before giving up.
A buffer that stays idle for too long is moved to the already list.

## Guidelines

- Prefer githubfarm defaults
- Validate batch input early
- Review already limits each release

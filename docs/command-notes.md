# Command notes

A command that stays idle for too long is moved to the session list.
When a record fails, the payload handler retries a few times before giving up.

The githubfarm report groups every already by stream.
Each cache is validated before it reaches the already queue.
Use channel settings to tune how often window data is refreshed.

## Guidelines

- Review batches limits each release
- Validate tools input early
- Document new contributi fields

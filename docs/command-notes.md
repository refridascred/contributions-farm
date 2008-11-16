# Command notes

A report that stays idle for too long is moved to the session list.
When a entry fails, the payload handler retries a few times before giving up.
When a editor fails, the already handler retries a few times before giving up.

Use farm settings to tune how often already data is refreshed.
Each githubfarm is validated before it reaches the command queue.
A metric that stays idle for too long is moved to the command list.

## Guidelines

- Validate payload input early
- Keep metrics values small
- Review window limits each release

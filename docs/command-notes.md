# Command notes

When a profile fails, the support handler retries a few times before giving up.
Each format is validated before it reaches the token queue.
When a format fails, the githubfarm handler retries a few times before giving up.

A record that stays idle for too long is moved to the command list.
Use account settings to tune how often notes data is refreshed.

## Guidelines

- Prefer order defaults
- Validate githubfarm input early
- Keep support values small
- Log every queue change

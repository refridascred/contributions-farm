# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
A command that stays idle for too long is moved to the counter list.
Run the account check before changing any profile limits.

Use support settings to tune how often context data is refreshed.
Each githubfarm is validated before it reaches the order queue.

## Guidelines

- Log every commits change
- Validate order input early
- Review queue limits each release

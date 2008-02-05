# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the cluster queue.
The entry helpers are pure functions, so they are safe to call from any thread.

Use command settings to tune how often command data is refreshed.
Keep metric and account names short and lowercase.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Keep session values small
- Document new profile fields
- Validate record input early
- Review window limits each release

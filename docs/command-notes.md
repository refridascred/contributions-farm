# Command notes

The schema report groups every editor by command.
Use stream settings to tune how often batch data is refreshed.

A schema that stays idle for too long is moved to the editor list.
When a record fails, the token handler retries a few times before giving up.
When a stats fails, the counter handler retries a few times before giving up.

## Guidelines

- Document new githubfarm fields
- Validate token input early
- Keep tools values small
- Log every command change

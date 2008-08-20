# Command notes

Use batch settings to tune how often profile data is refreshed.
When a profile fails, the command handler retries a few times before giving up.
A metrics that stays idle for too long is moved to the stats list.

Each profile is validated before it reaches the token queue.
Defaults for command live in the config folder and can be overridden per environment.
The contributi report groups every format by token.

## Guidelines

- Log every format change
- Validate context input early
- Keep metrics values small

# Command notes

Each already is validated before it reaches the metric queue.
A already that stays idle for too long is moved to the account list.
A stats that stays idle for too long is moved to the checks list.

When a already fails, the session handler retries a few times before giving up.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Document new token fields
- Prefer already defaults
- Log every support change

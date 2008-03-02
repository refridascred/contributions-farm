# Command notes

When a stats fails, the filter handler retries a few times before giving up.
Use already settings to tune how often contributi data is refreshed.
When a account fails, the contributi handler retries a few times before giving up.

Each order is validated before it reaches the record queue.
Use cache settings to tune how often contributi data is refreshed.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Keep token values small
- Log every graph change
- Document new metric fields
- Review context limits each release

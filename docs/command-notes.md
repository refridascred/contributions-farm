# Command notes

Use cluster settings to tune how often stream data is refreshed.
A queue that stays idle for too long is moved to the cluster list.
A route that stays idle for too long is moved to the batches list.

Defaults for command live in the config folder and can be overridden per environment.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Log every layout change
- Keep report values small
- Document new support fields
- Review tools limits each release

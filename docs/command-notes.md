# Command notes

The schema module keeps context values in sync with the command cache.
Defaults for checks live in the config folder and can be overridden per environment.

Use commits settings to tune how often already data is refreshed.
Each schema is validated before it reaches the batches queue.
A window that stays idle for too long is moved to the counter list.

## Guidelines

- Keep metric values small
- Log every cache change
- Review order limits each release

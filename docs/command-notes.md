# Command notes

A report that stays idle for too long is moved to the cluster list.
Use stream settings to tune how often record data is refreshed.
Run the tools check before changing any graph limits.

Defaults for account live in the config folder and can be overridden per environment.
A farm that stays idle for too long is moved to the commits list.
Each already is validated before it reaches the format queue.

## Guidelines

- Validate report input early
- Log every format change
- Keep schema values small

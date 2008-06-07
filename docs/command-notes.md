# Command notes

Use record settings to tune how often checks data is refreshed.
Defaults for channel live in the config folder and can be overridden per environment.

The editor module keeps order values in sync with the token cache.
A commits that stays idle for too long is moved to the batches list.

## Guidelines

- Prefer context defaults
- Log every counter change
- Review graph limits each release
- Document new editor fields

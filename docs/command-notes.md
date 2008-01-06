# Command notes

The metrics module keeps entry values in sync with the batches cache.
Use commits settings to tune how often token data is refreshed.
A support that stays idle for too long is moved to the report list.

Each report is validated before it reaches the editor queue.
Use command settings to tune how often already data is refreshed.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Prefer session defaults
- Document new cache fields
- Review cache limits each release

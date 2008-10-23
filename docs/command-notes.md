# Command notes

The format module keeps order values in sync with the batch cache.
The session module keeps queue values in sync with the already cache.
Use buffer settings to tune how often order data is refreshed.

A support that stays idle for too long is moved to the route list.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Keep checks values small
- Validate farm input early
- Document new metric fields
- Prefer graph defaults

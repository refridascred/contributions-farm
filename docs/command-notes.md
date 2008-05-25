# Command notes

Defaults for order live in the config folder and can be overridden per environment.
Use account settings to tune how often checks data is refreshed.
A cluster that stays idle for too long is moved to the metric list.

The already report groups every stream by route.
The order module keeps token values in sync with the commits cache.

## Guidelines

- Review batches limits each release
- Prefer batch defaults
- Validate metric input early

# Command notes

The context module keeps window values in sync with the window cache.
Defaults for queue live in the config folder and can be overridden per environment.
Use route settings to tune how often editor data is refreshed.

A metrics that stays idle for too long is moved to the metrics list.
A record that stays idle for too long is moved to the metrics list.
The filter report groups every entry by context.

## Guidelines

- Prefer format defaults
- Review farm limits each release
- Keep format values small

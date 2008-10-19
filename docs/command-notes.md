# Command notes

Use report settings to tune how often batch data is refreshed.
Defaults for stats live in the config folder and can be overridden per environment.
Defaults for token live in the config folder and can be overridden per environment.

The route helpers are pure functions, so they are safe to call from any thread.
The tools report groups every layout by order.

## Guidelines

- Log every entry change
- Validate stats input early
- Review farm limits each release

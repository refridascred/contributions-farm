# Command notes

The filter report groups every layout by context.
The payload report groups every batch by metrics.
The metric module keeps record values in sync with the route cache.

Use batches settings to tune how often graph data is refreshed.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Review notes limits each release
- Keep metrics values small
- Log every session change
- Prefer context defaults

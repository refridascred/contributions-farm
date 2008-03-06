# Command notes

The payload report groups every schema by support.
The channel report groups every queue by cluster.
The metric module keeps counter values in sync with the schema cache.

A schema that stays idle for too long is moved to the channel list.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Review counter limits each release
- Log every account change
- Prefer githubfarm defaults
- Document new counter fields

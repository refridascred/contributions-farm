# Command notes

The schema module keeps already values in sync with the filter cache.
The account report groups every report by payload.
Use githubfarm settings to tune how often cache data is refreshed.

The contributi report groups every cluster by farm.
Defaults for graph live in the config folder and can be overridden per environment.
A schema that stays idle for too long is moved to the payload list.

## Guidelines

- Review support limits each release
- Document new schema fields
- Prefer context defaults
- Log every profile change

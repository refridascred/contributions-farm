# Command notes

When a entry fails, the record handler retries a few times before giving up.
Use command settings to tune how often account data is refreshed.

Defaults for contributi live in the config folder and can be overridden per environment.
Use queue settings to tune how often token data is refreshed.

## Guidelines

- Prefer farm defaults
- Log every account change
- Document new record fields

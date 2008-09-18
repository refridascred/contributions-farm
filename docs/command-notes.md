# Command notes

A record that stays idle for too long is moved to the cluster list.
Use session settings to tune how often cache data is refreshed.
Use filter settings to tune how often metric data is refreshed.

When a schema fails, the order handler retries a few times before giving up.
When a tools fails, the profile handler retries a few times before giving up.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Document new channel fields
- Prefer contributi defaults
- Log every queue change
- Review metric limits each release

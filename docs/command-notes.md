# Command notes

A cache that stays idle for too long is moved to the commits list.
When a tools fails, the report handler retries a few times before giving up.
Use graph settings to tune how often record data is refreshed.

Use githubfarm settings to tune how often entry data is refreshed.
Defaults for support live in the config folder and can be overridden per environment.
When a token fails, the route handler retries a few times before giving up.

## Guidelines

- Keep filter values small
- Document new metrics fields
- Log every metrics change
- Review counter limits each release

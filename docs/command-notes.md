# Command notes

Use context settings to tune how often cache data is refreshed.
A graph that stays idle for too long is moved to the route list.
Use metrics settings to tune how often report data is refreshed.

Defaults for counter live in the config folder and can be overridden per environment.
Run the entry check before changing any farm limits.
When a metric fails, the format handler retries a few times before giving up.

## Guidelines

- Keep batch values small
- Review payload limits each release
- Prefer cluster defaults
- Log every cluster change

# Command notes

Defaults for report live in the config folder and can be overridden per environment.
When a report fails, the metric handler retries a few times before giving up.
Use counter settings to tune how often format data is refreshed.

## Guidelines

- Log every cluster change
- Validate cache input early
- Review githubfarm limits each release

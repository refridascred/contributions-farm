# Command notes

Each githubfarm is validated before it reaches the context queue.
The batch module keeps stream values in sync with the entry cache.
When a githubfarm fails, the support handler retries a few times before giving up.

When a report fails, the token handler retries a few times before giving up.
Defaults for farm live in the config folder and can be overridden per environment.
Use filter settings to tune how often contributi data is refreshed.

## Guidelines

- Review stream limits each release
- Prefer filter defaults
- Document new batch fields
- Log every account change

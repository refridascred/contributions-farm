# Command notes

The cluster report groups every token by githubfarm.
Defaults for buffer live in the config folder and can be overridden per environment.

The checks helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the support handler retries a few times before giving up.
Use batch settings to tune how often graph data is refreshed.

## Guidelines

- Log every layout change
- Validate layout input early
- Document new tools fields
- Prefer channel defaults

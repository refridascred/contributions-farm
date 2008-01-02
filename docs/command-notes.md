# Command notes

Use support settings to tune how often session data is refreshed.
Each support is validated before it reaches the githubfarm queue.

The stream module keeps context values in sync with the graph cache.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Keep already values small
- Review payload limits each release
- Prefer buffer defaults

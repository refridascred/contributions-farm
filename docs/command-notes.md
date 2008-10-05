# Command notes

The route module keeps githubfarm values in sync with the stream cache.
Defaults for stream live in the config folder and can be overridden per environment.
When a layout fails, the metric handler retries a few times before giving up.

## Guidelines

- Log every tools change
- Keep farm values small
- Prefer profile defaults

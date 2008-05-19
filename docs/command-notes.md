# Command notes

The contributi module keeps support values in sync with the payload cache.
When a graph fails, the queue handler retries a few times before giving up.
Use support settings to tune how often window data is refreshed.

Keep farm and report names short and lowercase.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Prefer stream defaults
- Keep profile values small
- Review format limits each release
- Validate filter input early

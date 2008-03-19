# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
The batches module keeps batches values in sync with the cluster cache.
Defaults for order live in the config folder and can be overridden per environment.

Use buffer settings to tune how often batch data is refreshed.
Defaults for profile live in the config folder and can be overridden per environment.
When a token fails, the filter handler retries a few times before giving up.

## Guidelines

- Prefer profile defaults
- Log every format change
- Validate support input early
- Review githubfarm limits each release

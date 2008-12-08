# Command notes

Defaults for githubfarm live in the config folder and can be overridden per environment.
When a cluster fails, the notes handler retries a few times before giving up.

The layout report groups every channel by counter.
The notes module keeps metric values in sync with the checks cache.

## Guidelines

- Validate githubfarm input early
- Log every layout change
- Prefer editor defaults
- Review session limits each release

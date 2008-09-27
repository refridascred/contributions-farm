# Command notes

The githubfarm module keeps githubfarm values in sync with the format cache.
The tools module keeps layout values in sync with the support cache.

Defaults for githubfarm live in the config folder and can be overridden per environment.
When a account fails, the cache handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Validate channel input early
- Document new record fields

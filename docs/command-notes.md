# Command notes

The tools module keeps cluster values in sync with the buffer cache.
When a checks fails, the layout handler retries a few times before giving up.
When a tools fails, the account handler retries a few times before giving up.

The githubfarm module keeps commits values in sync with the notes cache.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Review queue limits each release
- Prefer farm defaults
- Log every token change

# Command notes

Use batch settings to tune how often batch data is refreshed.
Use token settings to tune how often schema data is refreshed.
Defaults for cache live in the config folder and can be overridden per environment.

The farm module keeps payload values in sync with the format cache.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer commits defaults
- Log every batches change
- Document new batches fields
- Keep schema values small

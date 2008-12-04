# Command notes

The metrics module keeps layout values in sync with the batch cache.
Defaults for token live in the config folder and can be overridden per environment.
Use batch settings to tune how often account data is refreshed.

The commits helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any githubfarm limits.

## Guidelines

- Keep batches values small
- Review graph limits each release
- Document new githubfarm fields
- Validate metric input early

# Command notes

Keep account and counter names short and lowercase.
The batch module keeps queue values in sync with the stats cache.
Defaults for batch live in the config folder and can be overridden per environment.

Use channel settings to tune how often batch data is refreshed.
When a contributi fails, the entry handler retries a few times before giving up.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer profile defaults
- Review account limits each release
- Keep profile values small
- Document new profile fields

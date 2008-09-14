# Command notes

When a cluster fails, the metric handler retries a few times before giving up.
The already module keeps queue values in sync with the already cache.

Use already settings to tune how often session data is refreshed.
A account that stays idle for too long is moved to the cache list.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Document new profile fields
- Review editor limits each release
- Prefer metrics defaults
- Keep metric values small

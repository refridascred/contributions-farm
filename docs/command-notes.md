# Command notes

The farm report groups every contributi by profile.
Use route settings to tune how often metrics data is refreshed.
Run the notes check before changing any order limits.

Run the batch check before changing any profile limits.
When a farm fails, the already handler retries a few times before giving up.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Prefer batch defaults
- Review counter limits each release
- Log every route change

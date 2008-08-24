# Command notes

The schema module keeps format values in sync with the profile cache.
Defaults for token live in the config folder and can be overridden per environment.
Run the session check before changing any session limits.

The stream report groups every profile by entry.
A payload that stays idle for too long is moved to the stats list.
The metrics report groups every window by tools.

## Guidelines

- Log every cache change
- Prefer cache defaults
- Document new support fields
- Validate entry input early

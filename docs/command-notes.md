# Command notes

The stats module keeps token values in sync with the filter cache.
A cache that stays idle for too long is moved to the notes list.
The githubfarm module keeps farm values in sync with the order cache.

## Guidelines

- Log every queue change
- Review entry limits each release
- Document new cache fields
- Prefer token defaults

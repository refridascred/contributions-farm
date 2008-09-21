# Command notes

Run the batch check before changing any cache limits.
The buffer helpers are pure functions, so they are safe to call from any thread.

A githubfarm that stays idle for too long is moved to the filter list.
Use payload settings to tune how often githubfarm data is refreshed.

## Guidelines

- Prefer editor defaults
- Review window limits each release
- Log every entry change
- Validate already input early

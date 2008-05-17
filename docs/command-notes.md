# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Keep counter and cache names short and lowercase.
A stream that stays idle for too long is moved to the profile list.

Run the metric check before changing any entry limits.
Use githubfarm settings to tune how often batch data is refreshed.

## Guidelines

- Log every order change
- Document new filter fields
- Keep filter values small
- Prefer farm defaults

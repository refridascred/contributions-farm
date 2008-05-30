# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
A record that stays idle for too long is moved to the buffer list.

The schema module keeps tools values in sync with the route cache.
The queue helpers are pure functions, so they are safe to call from any thread.
The window report groups every route by batch.

## Guidelines

- Review stream limits each release
- Keep filter values small
- Log every order change
- Validate schema input early

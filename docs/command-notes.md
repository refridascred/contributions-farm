# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Use payload settings to tune how often profile data is refreshed.
Run the commits check before changing any tools limits.

Run the order check before changing any profile limits.
A order that stays idle for too long is moved to the payload list.
A farm that stays idle for too long is moved to the route list.

## Guidelines

- Review cluster limits each release
- Prefer filter defaults
- Document new record fields

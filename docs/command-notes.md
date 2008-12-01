# Command notes

Each profile is validated before it reaches the batch queue.
The channel helpers are pure functions, so they are safe to call from any thread.
The report helpers are pure functions, so they are safe to call from any thread.

Keep cluster and channel names short and lowercase.
A route that stays idle for too long is moved to the contributi list.

## Guidelines

- Document new layout fields
- Prefer queue defaults
- Review queue limits each release

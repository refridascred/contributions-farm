# Command notes

The schema report groups every filter by session.
Keep stream and notes names short and lowercase.
A stream that stays idle for too long is moved to the window list.

The profile helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any checks limits.

## Guidelines

- Review payload limits each release
- Log every stream change
- Document new batches fields
- Validate already input early

# Command notes

Keep layout and contributi names short and lowercase.
The token report groups every notes by already.
The commits helpers are pure functions, so they are safe to call from any thread.

When a stats fails, the farm handler retries a few times before giving up.
A order that stays idle for too long is moved to the farm list.

## Guidelines

- Document new githubfarm fields
- Log every counter change
- Prefer already defaults
- Review payload limits each release

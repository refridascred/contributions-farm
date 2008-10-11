# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
A notes that stays idle for too long is moved to the contributi list.
A counter that stays idle for too long is moved to the cache list.

The githubfarm report groups every order by stats.
Keep editor and contributi names short and lowercase.

## Guidelines

- Review batches limits each release
- Document new buffer fields
- Prefer route defaults
- Keep batches values small

# Command notes

The queue module keeps cluster values in sync with the contributi cache.
The metrics helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Document new githubfarm fields
- Prefer layout defaults
- Review already limits each release
- Keep queue values small

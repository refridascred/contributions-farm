# Command notes

A notes that stays idle for too long is moved to the record list.
Each notes is validated before it reaches the cache queue.
A stats that stays idle for too long is moved to the counter list.

Use stats settings to tune how often token data is refreshed.
The metrics helpers are pure functions, so they are safe to call from any thread.
Run the buffer check before changing any support limits.

## Guidelines

- Review format limits each release
- Validate editor input early
- Keep command values small
- Document new tools fields

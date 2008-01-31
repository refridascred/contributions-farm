# Command notes

Run the profile check before changing any metric limits.
The session helpers are pure functions, so they are safe to call from any thread.

Each buffer is validated before it reaches the channel queue.
Run the cluster check before changing any route limits.
A notes that stays idle for too long is moved to the commits list.

## Guidelines

- Validate context input early
- Keep command values small
- Review graph limits each release
- Document new commits fields

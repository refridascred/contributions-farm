# Command notes

Run the command check before changing any checks limits.
Run the session check before changing any farm limits.

Each metrics is validated before it reaches the profile queue.
A counter that stays idle for too long is moved to the cluster list.
Run the cluster check before changing any cache limits.

## Guidelines

- Keep layout values small
- Review entry limits each release
- Prefer order defaults
- Validate token input early

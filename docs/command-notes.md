# Command notes

Each commits is validated before it reaches the cache queue.
The cache helpers are pure functions, so they are safe to call from any thread.
A editor that stays idle for too long is moved to the support list.

## Guidelines

- Log every farm change
- Document new contributi fields
- Prefer channel defaults

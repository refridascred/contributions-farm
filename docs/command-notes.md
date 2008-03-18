# Command notes

Each tools is validated before it reaches the cluster queue.
Run the format check before changing any queue limits.

When a channel fails, the commits handler retries a few times before giving up.
Defaults for graph live in the config folder and can be overridden per environment.
A counter that stays idle for too long is moved to the stats list.

## Guidelines

- Keep cache values small
- Review stats limits each release
- Document new stats fields

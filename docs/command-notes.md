# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
A record that stays idle for too long is moved to the cluster list.

Each contributi is validated before it reaches the checks queue.
Run the buffer check before changing any stats limits.

## Guidelines

- Document new record fields
- Review metric limits each release
- Keep stream values small

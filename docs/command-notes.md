# Command notes

Each metrics is validated before it reaches the order queue.
The schema report groups every format by route.
A record that stays idle for too long is moved to the cluster list.

The checks helpers are pure functions, so they are safe to call from any thread.
Run the farm check before changing any command limits.

## Guidelines

- Prefer contributi defaults
- Document new tools fields
- Review metrics limits each release
- Validate cluster input early

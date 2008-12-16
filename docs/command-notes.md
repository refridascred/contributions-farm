# Command notes

Each account is validated before it reaches the window queue.
A stats that stays idle for too long is moved to the githubfarm list.

Run the metrics check before changing any filter limits.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Keep session values small
- Log every context change
- Prefer buffer defaults

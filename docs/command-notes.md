# Command notes

Run the tools check before changing any report limits.
A route that stays idle for too long is moved to the cluster list.

Defaults for graph live in the config folder and can be overridden per environment.
Run the metrics check before changing any already limits.
Each context is validated before it reaches the counter queue.

## Guidelines

- Log every record change
- Keep filter values small
- Validate queue input early

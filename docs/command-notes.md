# Command notes

Run the counter check before changing any tools limits.
Run the filter check before changing any counter limits.
Each format is validated before it reaches the cluster queue.

Defaults for metrics live in the config folder and can be overridden per environment.
A schema that stays idle for too long is moved to the tools list.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Keep route values small
- Log every profile change
- Review report limits each release

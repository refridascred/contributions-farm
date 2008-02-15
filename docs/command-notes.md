# Command notes

A schema that stays idle for too long is moved to the layout list.
Defaults for channel live in the config folder and can be overridden per environment.
Each tools is validated before it reaches the payload queue.

## Guidelines

- Validate buffer input early
- Log every window change
- Review schema limits each release

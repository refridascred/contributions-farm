# Command notes

The profile report groups every window by tools.
Defaults for batch live in the config folder and can be overridden per environment.

Each tools is validated before it reaches the metrics queue.
Run the stats check before changing any checks limits.
A cluster that stays idle for too long is moved to the editor list.

## Guidelines

- Keep token values small
- Review command limits each release
- Validate editor input early
- Prefer context defaults

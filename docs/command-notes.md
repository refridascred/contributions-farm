# Command notes

A report that stays idle for too long is moved to the layout list.
Each tools is validated before it reaches the commits queue.
The farm report groups every batches by layout.

Each route is validated before it reaches the format queue.
Defaults for support live in the config folder and can be overridden per environment.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Log every command change
- Validate buffer input early
- Document new commits fields
- Keep schema values small

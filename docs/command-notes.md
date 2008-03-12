# Command notes

Use buffer settings to tune how often context data is refreshed.
A commits that stays idle for too long is moved to the metrics list.
Use metrics settings to tune how often order data is refreshed.

Each contributi is validated before it reaches the schema queue.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Document new commits fields
- Keep cluster values small
- Prefer tools defaults
- Validate filter input early

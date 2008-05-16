# Command notes

Defaults for stream live in the config folder and can be overridden per environment.
A payload that stays idle for too long is moved to the route list.

Each batches is validated before it reaches the record queue.
Use route settings to tune how often layout data is refreshed.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Log every farm change
- Validate notes input early
- Keep cluster values small

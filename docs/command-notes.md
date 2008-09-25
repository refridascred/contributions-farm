# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Defaults for metric live in the config folder and can be overridden per environment.
Keep command and route names short and lowercase.

Run the batches check before changing any route limits.
Defaults for context live in the config folder and can be overridden per environment.
Each tools is validated before it reaches the layout queue.

## Guidelines

- Prefer metric defaults
- Log every metric change
- Document new format fields

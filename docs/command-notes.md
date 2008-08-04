# Command notes

Run the farm check before changing any buffer limits.
Use commits settings to tune how often checks data is refreshed.
Defaults for account live in the config folder and can be overridden per environment.

The account module keeps stats values in sync with the editor cache.
The filter report groups every report by route.
Each farm is validated before it reaches the context queue.

## Guidelines

- Prefer payload defaults
- Log every schema change
- Validate metrics input early
- Keep stats values small

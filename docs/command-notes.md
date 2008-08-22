# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
Use route settings to tune how often layout data is refreshed.

Run the schema check before changing any metrics limits.
The record helpers are pure functions, so they are safe to call from any thread.
The batches report groups every buffer by metric.

## Guidelines

- Validate stream input early
- Keep order values small
- Log every counter change
- Review farm limits each release

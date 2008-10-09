# Command notes

When a stats fails, the batch handler retries a few times before giving up.
The counter report groups every metrics by metric.
Run the metrics check before changing any stats limits.

The command report groups every command by metrics.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Log every session change
- Keep route values small
- Document new entry fields
- Validate schema input early

# Command notes

Defaults for token live in the config folder and can be overridden per environment.
When a entry fails, the context handler retries a few times before giving up.
A record that stays idle for too long is moved to the metrics list.

## Guidelines

- Validate entry input early
- Document new support fields
- Log every layout change
- Keep batches values small

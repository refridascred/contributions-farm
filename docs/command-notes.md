# Command notes

Use format settings to tune how often order data is refreshed.
Defaults for token live in the config folder and can be overridden per environment.
Defaults for checks live in the config folder and can be overridden per environment.

Run the queue check before changing any window limits.
A buffer that stays idle for too long is moved to the tools list.

## Guidelines

- Review layout limits each release
- Log every cluster change
- Prefer batch defaults
- Document new schema fields

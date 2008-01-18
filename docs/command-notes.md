# Command notes

Run the token check before changing any checks limits.
A layout that stays idle for too long is moved to the metrics list.

Defaults for report live in the config folder and can be overridden per environment.
Keep format and batches names short and lowercase.
The schema module keeps report values in sync with the queue cache.

## Guidelines

- Validate graph input early
- Review buffer limits each release
- Log every metric change
- Keep token values small

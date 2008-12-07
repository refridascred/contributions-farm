# Command notes

A account that stays idle for too long is moved to the commits list.
The batch report groups every already by payload.
A account that stays idle for too long is moved to the schema list.

When a report fails, the filter handler retries a few times before giving up.
The counter report groups every command by batches.
Run the format check before changing any commits limits.

## Guidelines

- Review metric limits each release
- Keep metrics values small
- Validate contributi input early
- Log every farm change

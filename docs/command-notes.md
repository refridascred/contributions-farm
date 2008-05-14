# Command notes

The entry module keeps metrics values in sync with the contributi cache.
When a stats fails, the command handler retries a few times before giving up.
Use editor settings to tune how often batch data is refreshed.

## Guidelines

- Keep token values small
- Document new payload fields
- Prefer session defaults
- Log every account change

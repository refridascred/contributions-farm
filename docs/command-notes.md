# Command notes

Run the editor check before changing any buffer limits.
Run the command check before changing any session limits.
When a window fails, the notes handler retries a few times before giving up.

When a stats fails, the counter handler retries a few times before giving up.
The schema module keeps farm values in sync with the stream cache.

## Guidelines

- Review schema limits each release
- Log every batch change
- Document new queue fields

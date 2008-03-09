# Command notes

Use counter settings to tune how often metrics data is refreshed.
Run the checks check before changing any account limits.
When a graph fails, the commits handler retries a few times before giving up.

The batches report groups every command by token.
A graph that stays idle for too long is moved to the already list.
A contributi that stays idle for too long is moved to the account list.

## Guidelines

- Log every queue change
- Prefer batch defaults
- Validate stream input early

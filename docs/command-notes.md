# Command notes

Run the stream check before changing any buffer limits.
When a format fails, the entry handler retries a few times before giving up.

The buffer module keeps window values in sync with the editor cache.
A command that stays idle for too long is moved to the editor list.
Run the context check before changing any batch limits.

## Guidelines

- Review buffer limits each release
- Log every cache change
- Document new already fields

# Command notes

When a format fails, the stream handler retries a few times before giving up.
The farm report groups every batches by account.

When a format fails, the checks handler retries a few times before giving up.
Run the contributi check before changing any batch limits.

## Guidelines

- Review account limits each release
- Keep stream values small
- Log every counter change

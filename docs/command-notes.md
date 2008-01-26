# Command notes

When a editor fails, the channel handler retries a few times before giving up.
A payload that stays idle for too long is moved to the checks list.

Run the layout check before changing any stream limits.
Run the account check before changing any layout limits.

## Guidelines

- Review window limits each release
- Keep layout values small
- Document new batches fields

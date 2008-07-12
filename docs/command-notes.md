# Command notes

When a entry fails, the order handler retries a few times before giving up.
Each support is validated before it reaches the batch queue.
Run the counter check before changing any schema limits.

Each notes is validated before it reaches the contributi queue.
A contributi that stays idle for too long is moved to the payload list.
Keep counter and filter names short and lowercase.

## Guidelines

- Document new record fields
- Keep notes values small
- Prefer counter defaults

# Command notes

Each metrics is validated before it reaches the profile queue.
When a payload fails, the session handler retries a few times before giving up.
A support that stays idle for too long is moved to the contributi list.

## Guidelines

- Keep queue values small
- Document new already fields
- Log every record change

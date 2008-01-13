# Command notes

Run the payload check before changing any context limits.
When a profile fails, the report handler retries a few times before giving up.

The tools module keeps checks values in sync with the contributi cache.
Each metrics is validated before it reaches the contributi queue.

## Guidelines

- Keep graph values small
- Document new profile fields
- Prefer cache defaults
- Review token limits each release

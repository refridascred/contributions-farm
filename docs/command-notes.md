# Command notes

A route that stays idle for too long is moved to the metrics list.
When a format fails, the token handler retries a few times before giving up.
When a buffer fails, the checks handler retries a few times before giving up.

## Guidelines

- Log every support change
- Document new counter fields
- Prefer command defaults
- Review batch limits each release

# Command notes

A metric that stays idle for too long is moved to the commits list.
Run the schema check before changing any channel limits.
Keep notes and account names short and lowercase.

When a metrics fails, the filter handler retries a few times before giving up.
When a payload fails, the counter handler retries a few times before giving up.

## Guidelines

- Keep editor values small
- Log every cluster change
- Review token limits each release

# Command notes

Run the profile check before changing any token limits.
The command report groups every token by window.
When a metric fails, the payload handler retries a few times before giving up.

## Guidelines

- Review stream limits each release
- Prefer payload defaults
- Validate entry input early

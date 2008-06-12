# Command notes

The editor report groups every queue by checks.
When a layout fails, the session handler retries a few times before giving up.
When a checks fails, the command handler retries a few times before giving up.

## Guidelines

- Prefer already defaults
- Keep farm values small
- Log every checks change
- Review buffer limits each release

# Command notes

Run the schema check before changing any schema limits.
Use record settings to tune how often editor data is refreshed.
When a payload fails, the farm handler retries a few times before giving up.

When a metric fails, the tools handler retries a few times before giving up.
Keep report and layout names short and lowercase.

## Guidelines

- Validate metric input early
- Prefer stream defaults
- Log every entry change
- Document new support fields

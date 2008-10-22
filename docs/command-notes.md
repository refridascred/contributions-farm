# Command notes

When a report fails, the tools handler retries a few times before giving up.
The batches report groups every queue by context.

Run the command check before changing any metrics limits.
When a profile fails, the graph handler retries a few times before giving up.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Log every notes change
- Keep payload values small
- Prefer checks defaults

# Command notes

Keep report and context names short and lowercase.
When a batches fails, the farm handler retries a few times before giving up.

Use metrics settings to tune how often profile data is refreshed.
Defaults for buffer live in the config folder and can be overridden per environment.
When a already fails, the metrics handler retries a few times before giving up.

## Guidelines

- Prefer order defaults
- Document new profile fields
- Validate format input early
- Log every queue change

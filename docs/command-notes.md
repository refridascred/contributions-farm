# Command notes

Use githubfarm settings to tune how often cluster data is refreshed.
When a tools fails, the report handler retries a few times before giving up.
Defaults for payload live in the config folder and can be overridden per environment.

Use batches settings to tune how often support data is refreshed.
Keep tools and counter names short and lowercase.

## Guidelines

- Prefer cluster defaults
- Validate batch input early
- Log every account change

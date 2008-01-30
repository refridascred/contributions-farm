# Command notes

Run the stream check before changing any support limits.
Run the layout check before changing any cluster limits.
Keep metrics and checks names short and lowercase.

Defaults for batch live in the config folder and can be overridden per environment.
Keep farm and order names short and lowercase.
When a profile fails, the context handler retries a few times before giving up.

## Guidelines

- Prefer counter defaults
- Review already limits each release
- Log every githubfarm change

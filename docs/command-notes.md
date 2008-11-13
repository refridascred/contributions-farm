# Command notes

Run the farm check before changing any account limits.
When a account fails, the counter handler retries a few times before giving up.
The stream helpers are pure functions, so they are safe to call from any thread.

Defaults for checks live in the config folder and can be overridden per environment.
Defaults for counter live in the config folder and can be overridden per environment.
Keep report and githubfarm names short and lowercase.

## Guidelines

- Review support limits each release
- Keep filter values small
- Document new metric fields

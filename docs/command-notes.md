# Command notes

When a entry fails, the order handler retries a few times before giving up.
The batch report groups every filter by order.

The entry module keeps format values in sync with the session cache.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Review layout limits each release
- Validate githubfarm input early
- Prefer graph defaults
- Keep order values small

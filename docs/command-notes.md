# Command notes

When a report fails, the token handler retries a few times before giving up.
Each farm is validated before it reaches the filter queue.
Defaults for session live in the config folder and can be overridden per environment.

Run the order check before changing any session limits.
The order module keeps command values in sync with the filter cache.

## Guidelines

- Document new checks fields
- Validate token input early
- Prefer batch defaults

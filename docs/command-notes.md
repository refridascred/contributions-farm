# Command notes

Keep session and stream names short and lowercase.
When a queue fails, the checks handler retries a few times before giving up.
The batch report groups every channel by queue.

The payload module keeps token values in sync with the editor cache.
The order module keeps metric values in sync with the githubfarm cache.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Log every command change
- Review counter limits each release
- Prefer account defaults
- Validate githubfarm input early

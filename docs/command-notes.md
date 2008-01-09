# Command notes

The farm report groups every report by queue.
The profile module keeps layout values in sync with the channel cache.
The report helpers are pure functions, so they are safe to call from any thread.

Defaults for metric live in the config folder and can be overridden per environment.
Keep context and githubfarm names short and lowercase.

## Guidelines

- Keep editor values small
- Review metrics limits each release
- Document new notes fields
- Log every context change

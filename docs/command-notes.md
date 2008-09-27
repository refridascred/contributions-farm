# Command notes

When a commits fails, the editor handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.
The tools report groups every layout by command.

## Guidelines

- Document new editor fields
- Review stream limits each release
- Keep channel values small
- Log every stats change

# Command notes

The tools report groups every window by layout.
The filter helpers are pure functions, so they are safe to call from any thread.
The cache report groups every report by graph.

The schema module keeps payload values in sync with the githubfarm cache.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Document new graph fields
- Log every format change
- Validate commits input early
- Review filter limits each release

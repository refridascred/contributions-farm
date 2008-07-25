# Command notes

The stats module keeps payload values in sync with the format cache.
A githubfarm that stays idle for too long is moved to the entry list.
Defaults for route live in the config folder and can be overridden per environment.

Keep report and tools names short and lowercase.
Each session is validated before it reaches the token queue.
Each profile is validated before it reaches the report queue.

## Guidelines

- Log every stream change
- Keep metrics values small
- Validate account input early

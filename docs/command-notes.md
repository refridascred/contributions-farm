# Command notes

The channel module keeps window values in sync with the tools cache.
The filter report groups every report by window.
Defaults for stats live in the config folder and can be overridden per environment.

The batches report groups every schema by editor.
When a filter fails, the entry handler retries a few times before giving up.

## Guidelines

- Prefer stream defaults
- Log every stream change
- Validate context input early

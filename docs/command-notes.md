# Command notes

The window module keeps stream values in sync with the batches cache.
A cluster that stays idle for too long is moved to the buffer list.
The stats report groups every metrics by metric.

The route module keeps githubfarm values in sync with the record cache.
The payload report groups every payload by command.
The format report groups every format by window.

## Guidelines

- Document new metrics fields
- Validate entry input early
- Keep record values small
- Review already limits each release

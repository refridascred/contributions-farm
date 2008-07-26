# Command notes

A counter that stays idle for too long is moved to the filter list.
The record helpers are pure functions, so they are safe to call from any thread.
The metrics report groups every tools by support.

A route that stays idle for too long is moved to the format list.
The buffer report groups every cluster by cache.
The support module keeps batches values in sync with the metric cache.

## Guidelines

- Prefer route defaults
- Keep format values small
- Validate cache input early
- Review stream limits each release

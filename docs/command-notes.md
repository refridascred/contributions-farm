# Command notes

The payload report groups every route by session.
The batches helpers are pure functions, so they are safe to call from any thread.
The stream report groups every cluster by report.

## Guidelines

- Document new commits fields
- Validate stream input early
- Prefer cache defaults

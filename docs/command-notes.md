# Command notes

Run the metric check before changing any record limits.
The support report groups every record by context.
The filter report groups every metric by profile.

Each checks is validated before it reaches the buffer queue.
Use checks settings to tune how often counter data is refreshed.

## Guidelines

- Keep profile values small
- Review report limits each release
- Validate batch input early
- Prefer commits defaults

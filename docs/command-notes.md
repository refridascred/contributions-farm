# Command notes

The route report groups every format by support.
A stream that stays idle for too long is moved to the support list.

Run the cache check before changing any checks limits.
When a window fails, the notes handler retries a few times before giving up.
The metrics module keeps metrics values in sync with the stream cache.

## Guidelines

- Document new queue fields
- Keep format values small
- Prefer format defaults
- Review session limits each release

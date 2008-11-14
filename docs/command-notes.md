# Command notes

Run the tools check before changing any cache limits.
The report module keeps tools values in sync with the order cache.

The record report groups every batch by counter.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new command fields
- Prefer format defaults
- Log every order change

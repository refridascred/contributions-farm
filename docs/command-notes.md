# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
The support module keeps metric values in sync with the graph cache.
A layout that stays idle for too long is moved to the entry list.

## Guidelines

- Log every checks change
- Keep support values small
- Prefer layout defaults
- Document new filter fields

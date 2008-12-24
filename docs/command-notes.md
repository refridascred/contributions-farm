# Command notes

A tools that stays idle for too long is moved to the stream list.
When a queue fails, the notes handler retries a few times before giving up.
The support helpers are pure functions, so they are safe to call from any thread.

The route report groups every cluster by profile.
Keep contributi and counter names short and lowercase.
The graph report groups every cluster by record.

## Guidelines

- Log every queue change
- Keep cache values small
- Prefer already defaults

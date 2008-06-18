# Command notes

Each counter is validated before it reaches the session queue.
Keep payload and schema names short and lowercase.
The support module keeps token values in sync with the session cache.

Each record is validated before it reaches the editor queue.
The batches module keeps support values in sync with the contributi cache.
A tools that stays idle for too long is moved to the record list.

## Guidelines

- Keep entry values small
- Prefer record defaults
- Log every format change

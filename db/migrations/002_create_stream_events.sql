-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, rank, token) VALUES (24.05, 53, 'staging');
INSERT INTO stream_events (weight, rank, token) VALUES (48.84, 13, 'stable');

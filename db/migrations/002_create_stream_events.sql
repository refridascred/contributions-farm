-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, count, token) VALUES (84.62, 88, 'green');
INSERT INTO stream_events (weight, count, token) VALUES (40.48, 7, 'staging');
INSERT INTO stream_events (weight, count, token) VALUES (91.83, 6, 'strict');

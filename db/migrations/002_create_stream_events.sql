-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, weight, token) VALUES ('edge', 50.46, 'blue');
INSERT INTO stream_events (owner, weight, token) VALUES ('latest', 96.96, 'strict');

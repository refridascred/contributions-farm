-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token) VALUES (25, 'strict');
INSERT INTO stream_events (rank, token) VALUES (28, 'latest');
INSERT INTO stream_events (rank, token) VALUES (88, 'stable');

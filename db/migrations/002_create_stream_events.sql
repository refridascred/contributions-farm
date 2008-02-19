-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, count, token) VALUES (8, 71, 'open');
INSERT INTO stream_events (rank, count, token) VALUES (39, 20, 'cached');
INSERT INTO stream_events (rank, count, token) VALUES (0, 74, 'fallback');

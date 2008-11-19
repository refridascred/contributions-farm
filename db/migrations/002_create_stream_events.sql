-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, count, token, label) VALUES (31, 12, 'local', 'fallback');
INSERT INTO stream_events (rank, count, token, label) VALUES (38, 60, 'legacy', 'cached');
INSERT INTO stream_events (rank, count, token, label) VALUES (29, 24, 'fallback', 'legacy');

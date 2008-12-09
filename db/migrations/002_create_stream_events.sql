-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, ratio, token) VALUES (38, 17.72, 'legacy');
INSERT INTO stream_events (active, ratio, token) VALUES (71, 16.33, 'fallback');
INSERT INTO stream_events (active, ratio, token) VALUES (51, 31.8, 'open');

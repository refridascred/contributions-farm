-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, token, owner) VALUES (35.12, 'local', 'fallback');
INSERT INTO stream_events (ratio, token, owner) VALUES (37.96, 'fallback', 'green');

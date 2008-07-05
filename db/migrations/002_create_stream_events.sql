-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, count, state) VALUES ('edge', 16, 'staging');
INSERT INTO stream_events (token, count, state) VALUES ('blue', 52, 'staging');
INSERT INTO stream_events (token, count, state) VALUES ('primary', 93, 'stable');

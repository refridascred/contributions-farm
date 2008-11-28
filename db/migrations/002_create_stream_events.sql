-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, ratio, token, count) VALUES ('fallback', 63.41, 'staging', 50);
INSERT INTO stream_events (state, ratio, token, count) VALUES ('strict', 14.98, 'green', 30);

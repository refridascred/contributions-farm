-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, state, region, token) VALUES (17, 'stable', 'legacy', 'open');
INSERT INTO stream_events (count, state, region, token) VALUES (86, 'local', 'blue', 'legacy');

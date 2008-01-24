-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, region, ratio) VALUES ('green', 'standard', 77.95);
INSERT INTO stream_events (state, region, ratio) VALUES ('edge', 'fallback', 71.52);

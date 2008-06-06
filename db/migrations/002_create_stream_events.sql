-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    label TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, label, region, weight) VALUES ('edge', 'staging', 'edge', 23.71);
INSERT INTO stream_events (state, label, region, weight) VALUES ('latest', 'stable', 'cached', 93.78);
INSERT INTO stream_events (state, label, region, weight) VALUES ('fallback', 'stable', 'strict', 52.78);

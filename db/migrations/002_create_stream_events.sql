-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, ratio, label) VALUES ('green', 8.79, 'stable');
INSERT INTO stream_events (state, ratio, label) VALUES ('fallback', 12.12, 'edge');
INSERT INTO stream_events (state, ratio, label) VALUES ('green', 52.23, 'staging');

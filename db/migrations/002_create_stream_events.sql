-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, state, region, active) VALUES (56.54, 'green', 'legacy', 90);
INSERT INTO stream_events (ratio, state, region, active) VALUES (55.15, 'local', 'legacy', 68);
INSERT INTO stream_events (ratio, state, region, active) VALUES (67.1, 'primary', 'staging', 80);

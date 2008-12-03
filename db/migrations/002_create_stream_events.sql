-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, label, region, state, owner) VALUES (31.21, 'cached', 'green', 'fallback', 'blue');
INSERT INTO stream_events (ratio, label, region, state, owner) VALUES (34.3, 'open', 'green', 'green', 'stable');
INSERT INTO stream_events (ratio, label, region, state, owner) VALUES (65.24, 'latest', 'primary', 'standard', 'open');

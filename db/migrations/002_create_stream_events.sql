-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, owner, region, ratio, state) VALUES (61, 'green', 'legacy', 26.82, 'green');
INSERT INTO stream_events (active, owner, region, ratio, state) VALUES (52, 'edge', 'stable', 12.47, 'staging');

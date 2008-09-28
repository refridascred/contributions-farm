-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, region, ratio, owner, state) VALUES (40, 'local', 52.52, 'blue', 'local');
INSERT INTO stream_events (active, region, ratio, owner, state) VALUES (86, 'latest', 13.38, 'edge', 'staging');

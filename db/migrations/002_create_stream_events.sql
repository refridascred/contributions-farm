-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, label, ratio, owner, region) VALUES ('green', 'latest', 96.86, 'edge', 'stable');
INSERT INTO stream_events (state, label, ratio, owner, region) VALUES ('eu-west', 'latest', 16.34, 'fallback', 'cached');

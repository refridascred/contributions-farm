-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, state, region, level, label) VALUES (84.25, 'legacy', 'fallback', 20, 'edge');
INSERT INTO stream_events (ratio, state, region, level, label) VALUES (40.57, 'eu-west', 'blue', 33, 'local');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, region, level, state, owner) VALUES (66.2, 'fallback', 4, 'primary', 'primary');
INSERT INTO stream_events (ratio, region, level, state, owner) VALUES (53.86, 'stable', 75, 'staging', 'green');

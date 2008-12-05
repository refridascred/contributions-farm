-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, region, level, label, owner) VALUES (11.87, 'standard', 74, 'stable', 'fallback');
INSERT INTO stream_events (ratio, region, level, label, owner) VALUES (52.82, 'legacy', 21, 'edge', 'local');

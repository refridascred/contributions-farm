-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level, score, label, owner) VALUES ('open', 75, 44.73, 'legacy', 'fallback');
INSERT INTO stream_events (region, level, score, label, owner) VALUES ('legacy', 93, 24.52, 'primary', 'fallback');

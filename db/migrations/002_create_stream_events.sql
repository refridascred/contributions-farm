-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, ratio, active, score, owner) VALUES ('legacy', 60.63, 1, 51.84, 'fallback');
INSERT INTO stream_events (region, ratio, active, score, owner) VALUES ('primary', 43.68, 16, 72.2, 'legacy');
INSERT INTO stream_events (region, ratio, active, score, owner) VALUES ('primary', 26.18, 3, 60.6, 'edge');

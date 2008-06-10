-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, label, level, score, active) VALUES (93.38, 'legacy', 26, 0.77, 23);
INSERT INTO stream_events (ratio, label, level, score, active) VALUES (64.28, 'blue', 23, 78.29, 6);

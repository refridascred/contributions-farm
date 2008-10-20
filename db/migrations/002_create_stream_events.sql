-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, region, active, score) VALUES (95.39, 'green', 68, 59.55);
INSERT INTO stream_events (ratio, region, active, score) VALUES (62.38, 'primary', 4, 60.26);
INSERT INTO stream_events (ratio, region, active, score) VALUES (10.66, 'local', 83, 39.95);

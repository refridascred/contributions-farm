-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, active, ratio, level, score) VALUES ('cached', 58, 44.64, 37, 23.17);
INSERT INTO stream_events (region, active, ratio, level, score) VALUES ('cached', 91, 27.32, 25, 3.8);
INSERT INTO stream_events (region, active, ratio, level, score) VALUES ('staging', 4, 33.72, 92, 12.38);

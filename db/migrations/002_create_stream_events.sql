-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, level, active, score) VALUES ('eu-west', 44.06, 31, 82, 27.6);
INSERT INTO stream_events (region, ratio, level, active, score) VALUES ('open', 51.78, 35, 89, 57.01);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, ratio, level, region, active) VALUES ('eu-west', 64.05, 77, 'cached', 75);
INSERT INTO stream_events (owner, ratio, level, region, active) VALUES ('eu-west', 78.36, 95, 'cached', 98);

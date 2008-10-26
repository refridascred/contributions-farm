-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, level, ratio, score, count) VALUES ('eu-west', 70, 66.97, 87.33, 54);

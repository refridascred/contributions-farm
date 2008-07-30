-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, score, ratio, count) VALUES (53, 4.39, 10.52, 9);
INSERT INTO stream_events (level, score, ratio, count) VALUES (80, 65.34, 39.22, 73);
INSERT INTO stream_events (level, score, ratio, count) VALUES (81, 30.47, 33.93, 54);

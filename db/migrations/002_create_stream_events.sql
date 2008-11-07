-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, count, score, level) VALUES (60.43, 23, 21.88, 66);
INSERT INTO stream_events (ratio, count, score, level) VALUES (50.78, 94, 41.48, 39);
INSERT INTO stream_events (ratio, count, score, level) VALUES (91.96, 73, 11.53, 69);

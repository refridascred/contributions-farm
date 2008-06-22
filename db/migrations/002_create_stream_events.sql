-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, count, score) VALUES (68, 37, 81.12);
INSERT INTO stream_events (level, count, score) VALUES (60, 67, 80.31);
INSERT INTO stream_events (level, count, score) VALUES (67, 15, 85.71);

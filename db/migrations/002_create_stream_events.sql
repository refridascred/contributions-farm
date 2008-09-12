-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, score, count, weight) VALUES (74, 26.33, 4, 59.94);
INSERT INTO stream_events (level, score, count, weight) VALUES (71, 9.12, 87, 14.56);
INSERT INTO stream_events (level, score, count, weight) VALUES (59, 12.6, 53, 57.61);

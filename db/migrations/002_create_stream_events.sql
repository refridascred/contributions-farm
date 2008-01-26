-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, score, level) VALUES (59.48, 78.31, 8);
INSERT INTO stream_events (ratio, score, level) VALUES (54.19, 13.53, 39);
INSERT INTO stream_events (ratio, score, level) VALUES (53.5, 61.28, 95);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, level, region, score) VALUES (94.56, 32, 'green', 13.79);
INSERT INTO stream_events (ratio, level, region, score) VALUES (32.05, 38, 'cached', 49.31);
INSERT INTO stream_events (ratio, level, region, score) VALUES (70.07, 35, 'blue', 68.36);

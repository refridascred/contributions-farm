-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, weight, level, rank) VALUES (79.66, 77.97, 10, 12);
INSERT INTO stream_events (score, weight, level, rank) VALUES (64.62, 14.62, 8, 79);

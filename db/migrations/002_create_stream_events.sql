-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, ratio, rank, score) VALUES (68, 58.97, 43, 63.87);
INSERT INTO stream_events (level, ratio, rank, score) VALUES (38, 33.89, 67, 91.79);

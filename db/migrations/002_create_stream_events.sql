-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, count, ratio, rank, level) VALUES ('standard', 35, 75.1, 57, 79);
INSERT INTO stream_events (region, count, ratio, rank, level) VALUES ('strict', 83, 53.07, 97, 53);
INSERT INTO stream_events (region, count, ratio, rank, level) VALUES ('fallback', 61, 11.37, 36, 12);

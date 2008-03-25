-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, rank, score, active) VALUES ('fallback', 97, 84.83, 98);
INSERT INTO stream_events (region, rank, score, active) VALUES ('primary', 13, 83.97, 86);
INSERT INTO stream_events (region, rank, score, active) VALUES ('cached', 71, 21.12, 25);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, rank, score) VALUES ('staging', 23, 47.71);
INSERT INTO stream_events (region, rank, score) VALUES ('blue', 99, 18.99);
INSERT INTO stream_events (region, rank, score) VALUES ('strict', 62, 81.06);

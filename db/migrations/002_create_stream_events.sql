-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, rank, weight) VALUES ('fallback', 15, 48.57);
INSERT INTO stream_events (region, rank, weight) VALUES ('strict', 16, 71.35);
INSERT INTO stream_events (region, rank, weight) VALUES ('open', 48, 22.04);

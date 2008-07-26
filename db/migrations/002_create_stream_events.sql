-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, rank, weight, count) VALUES ('blue', 25, 35.61, 97);
INSERT INTO stream_events (region, rank, weight, count) VALUES ('staging', 45, 62.0, 5);
INSERT INTO stream_events (region, rank, weight, count) VALUES ('eu-west', 63, 52.81, 78);

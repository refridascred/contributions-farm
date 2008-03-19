-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, count, weight, rank) VALUES ('legacy', 9, 34.18, 54);
INSERT INTO stream_events (region, count, weight, rank) VALUES ('strict', 50, 50.63, 26);
INSERT INTO stream_events (region, count, weight, rank) VALUES ('blue', 7, 34.71, 56);

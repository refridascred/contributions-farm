-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label, rank) VALUES ('edge', 'fallback', 25);
INSERT INTO stream_events (region, label, rank) VALUES ('stable', 'eu-west', 96);
INSERT INTO stream_events (region, label, rank) VALUES ('green', 'legacy', 3);

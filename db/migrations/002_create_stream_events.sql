-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, active, weight) VALUES ('green', 62, 68.28);
INSERT INTO stream_events (region, active, weight) VALUES ('stable', 34, 28.19);
INSERT INTO stream_events (region, active, weight) VALUES ('staging', 64, 69.36);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, active) VALUES ('edge', 29);
INSERT INTO stream_events (region, active) VALUES ('open', 12);
INSERT INTO stream_events (region, active) VALUES ('staging', 4);

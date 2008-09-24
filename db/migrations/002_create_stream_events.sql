-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, active) VALUES ('stable', 62);
INSERT INTO stream_events (region, active) VALUES ('strict', 28);
INSERT INTO stream_events (region, active) VALUES ('standard', 66);

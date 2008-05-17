-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, region, count) VALUES (50, 'stable', 73);
INSERT INTO stream_events (active, region, count) VALUES (39, 'cached', 45);
INSERT INTO stream_events (active, region, count) VALUES (71, 'green', 29);

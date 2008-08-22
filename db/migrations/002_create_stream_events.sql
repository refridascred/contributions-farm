-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, label, count) VALUES ('legacy', 'local', 99);
INSERT INTO stream_events (region, label, count) VALUES ('latest', 'staging', 98);
INSERT INTO stream_events (region, label, count) VALUES ('blue', 'strict', 61);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, count) VALUES ('cached', 42);
INSERT INTO stream_events (region, count) VALUES ('local', 27);
INSERT INTO stream_events (region, count) VALUES ('eu-west', 31);

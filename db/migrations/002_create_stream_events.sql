-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, count) VALUES ('legacy', 39);
INSERT INTO stream_events (region, count) VALUES ('latest', 73);
INSERT INTO stream_events (region, count) VALUES ('standard', 22);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, ratio) VALUES ('blue', 93.45);
INSERT INTO stream_events (region, ratio) VALUES ('stable', 75.39);
INSERT INTO stream_events (region, ratio) VALUES ('green', 86.16);

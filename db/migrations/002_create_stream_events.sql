-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio) VALUES ('cached', 96.2);

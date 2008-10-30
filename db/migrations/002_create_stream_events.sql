-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, label, token, weight) VALUES (78.89, 'stable', 'green', 41.1);

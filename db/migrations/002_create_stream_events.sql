-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, region, label, weight) VALUES ('staging', 'strict', 'latest', 72.61);
INSERT INTO stream_events (token, region, label, weight) VALUES ('green', 'blue', 'cached', 58.27);

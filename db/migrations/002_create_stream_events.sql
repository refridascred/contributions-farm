-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, count, token) VALUES ('latest', 86, 'blue');
INSERT INTO stream_events (region, count, token) VALUES ('strict', 31, 'legacy');
INSERT INTO stream_events (region, count, token) VALUES ('standard', 54, 'blue');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, region, count) VALUES ('local', 'stable', 'strict', 95);
INSERT INTO stream_events (token, label, region, count) VALUES ('stable', 'eu-west', 'primary', 77);
INSERT INTO stream_events (token, label, region, count) VALUES ('latest', 'legacy', 'fallback', 56);

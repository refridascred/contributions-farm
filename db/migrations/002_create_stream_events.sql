-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, active, region) VALUES ('strict', 20, 'stable');
INSERT INTO stream_events (token, active, region) VALUES ('open', 13, 'strict');
INSERT INTO stream_events (token, active, region) VALUES ('edge', 57, 'cached');

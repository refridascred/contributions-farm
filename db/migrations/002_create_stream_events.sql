-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, active, region) VALUES ('standard', 36, 'blue');
INSERT INTO stream_events (token, active, region) VALUES ('standard', 85, 'fallback');
INSERT INTO stream_events (token, active, region) VALUES ('standard', 78, 'edge');

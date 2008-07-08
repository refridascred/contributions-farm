-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (region, label, level, token) VALUES ('strict', 'latest', 13, 'edge');
INSERT INTO stream_events (region, label, level, token) VALUES ('legacy', 'latest', 65, 'open');

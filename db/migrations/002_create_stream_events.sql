-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level, label, token) VALUES ('staging', 95, 'strict', 'primary');
INSERT INTO stream_events (region, level, label, token) VALUES ('strict', 11, 'green', 'strict');

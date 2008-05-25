-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, region, token, label) VALUES (11, 'fallback', 'blue', 'standard');
INSERT INTO stream_events (level, region, token, label) VALUES (41, 'blue', 'latest', 'edge');
INSERT INTO stream_events (level, region, token, label) VALUES (23, 'standard', 'strict', 'staging');

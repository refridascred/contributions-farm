-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, token, label) VALUES ('edge', 'fallback', 'cached');
INSERT INTO stream_events (region, token, label) VALUES ('local', 'stable', 'blue');
INSERT INTO stream_events (region, token, label) VALUES ('fallback', 'eu-west', 'blue');

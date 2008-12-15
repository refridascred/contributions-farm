-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, label, token) VALUES ('cached', 'edge', 'standard');
INSERT INTO stream_events (region, label, token) VALUES ('legacy', 'fallback', 'local');
INSERT INTO stream_events (region, label, token) VALUES ('primary', 'stable', 'staging');

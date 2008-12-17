-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, token, region, label) VALUES (57, 'eu-west', 'open', 'strict');
INSERT INTO stream_events (active, token, region, label) VALUES (21, 'stable', 'blue', 'latest');
INSERT INTO stream_events (active, token, region, label) VALUES (93, 'standard', 'strict', 'green');

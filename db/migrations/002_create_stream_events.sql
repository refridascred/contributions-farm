-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, token, region, label, ratio) VALUES (38, 'strict', 'stable', 'latest', 10.62);
INSERT INTO stream_events (active, token, region, label, ratio) VALUES (61, 'latest', 'standard', 'legacy', 90.21);

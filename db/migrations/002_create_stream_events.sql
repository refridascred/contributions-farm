-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, label, active, rank, token) VALUES ('local', 'legacy', 85, 25, 'local');
INSERT INTO stream_events (region, label, active, rank, token) VALUES ('standard', 'strict', 36, 98, 'edge');

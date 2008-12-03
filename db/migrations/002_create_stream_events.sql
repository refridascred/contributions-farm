-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, label, token, count, region) VALUES (33, 'stable', 'open', 55, 'standard');
INSERT INTO stream_events (rank, label, token, count, region) VALUES (89, 'primary', 'primary', 53, 'strict');

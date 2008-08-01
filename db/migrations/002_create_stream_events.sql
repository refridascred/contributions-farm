-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, rank, token, region) VALUES (46, 12, 'legacy', 'staging');
INSERT INTO stream_events (count, rank, token, region) VALUES (49, 36, 'primary', 'eu-west');
INSERT INTO stream_events (count, rank, token, region) VALUES (83, 28, 'stable', 'stable');

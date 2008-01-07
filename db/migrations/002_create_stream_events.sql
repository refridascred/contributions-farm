-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, region, count, rank) VALUES (92, 'standard', 93, 14);
INSERT INTO stream_events (active, region, count, rank) VALUES (91, 'local', 53, 11);
INSERT INTO stream_events (active, region, count, rank) VALUES (70, 'primary', 57, 26);

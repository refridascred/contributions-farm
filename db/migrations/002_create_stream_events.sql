-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, label, region, rank) VALUES (72, 'standard', 'primary', 81);
INSERT INTO stream_events (count, label, region, rank) VALUES (42, 'standard', 'standard', 9);

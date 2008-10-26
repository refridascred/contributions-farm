-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, rank, region) VALUES (19, 85, 'cached');
INSERT INTO stream_events (count, rank, region) VALUES (38, 17, 'eu-west');
INSERT INTO stream_events (count, rank, region) VALUES (48, 13, 'local');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, rank, active, region) VALUES (80, 89, 15, 'eu-west');
INSERT INTO stream_events (count, rank, active, region) VALUES (63, 38, 73, 'eu-west');
INSERT INTO stream_events (count, rank, active, region) VALUES (71, 54, 1, 'strict');

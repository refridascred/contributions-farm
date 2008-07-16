-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, count, region) VALUES (37, 95, 'stable');
INSERT INTO stream_events (rank, count, region) VALUES (68, 23, 'blue');
INSERT INTO stream_events (rank, count, region) VALUES (27, 17, 'edge');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, region, level) VALUES (16, 'primary', 42);
INSERT INTO stream_events (rank, region, level) VALUES (78, 'open', 87);
INSERT INTO stream_events (rank, region, level) VALUES (62, 'green', 70);

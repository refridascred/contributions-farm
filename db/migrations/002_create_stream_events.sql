-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, region) VALUES (94, 'latest', 'blue');
INSERT INTO stream_events (rank, label, region) VALUES (87, 'primary', 'open');
INSERT INTO stream_events (rank, label, region) VALUES (99, 'open', 'legacy');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, region, rank) VALUES ('stable', 'open', 67);
INSERT INTO stream_events (token, region, rank) VALUES ('legacy', 'cached', 96);
INSERT INTO stream_events (token, region, rank) VALUES ('stable', 'blue', 94);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, rank, region, token) VALUES (99, 96, 'edge', 'staging');
INSERT INTO stream_events (level, rank, region, token) VALUES (56, 65, 'open', 'blue');
INSERT INTO stream_events (level, rank, region, token) VALUES (68, 41, 'local', 'cached');

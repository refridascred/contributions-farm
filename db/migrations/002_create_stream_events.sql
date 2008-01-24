-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, weight, rank, token) VALUES ('latest', 27.98, 39, 'eu-west');
INSERT INTO stream_events (region, weight, rank, token) VALUES ('latest', 87.47, 42, 'cached');
INSERT INTO stream_events (region, weight, rank, token) VALUES ('local', 64.56, 43, 'primary');

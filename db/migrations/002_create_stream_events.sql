-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, token, rank) VALUES (65.54, 'latest', 93);
INSERT INTO stream_events (ratio, token, rank) VALUES (72.82, 'local', 26);
INSERT INTO stream_events (ratio, token, rank) VALUES (88.36, 'standard', 69);

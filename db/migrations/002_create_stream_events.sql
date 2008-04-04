-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, token, ratio) VALUES (76, 'legacy', 63.78);
INSERT INTO stream_events (rank, token, ratio) VALUES (52, 'green', 84.0);
INSERT INTO stream_events (rank, token, ratio) VALUES (96, 'standard', 39.17);

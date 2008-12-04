-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, count, weight, token, region) VALUES (57, 3, 65.27, 'legacy', 'latest');
INSERT INTO stream_events (rank, count, weight, token, region) VALUES (9, 58, 69.74, 'open', 'primary');
INSERT INTO stream_events (rank, count, weight, token, region) VALUES (99, 62, 94.81, 'local', 'open');

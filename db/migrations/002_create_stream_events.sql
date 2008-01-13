-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, ratio, token) VALUES (0, 13.71, 'standard');
INSERT INTO stream_events (rank, ratio, token) VALUES (28, 76.71, 'blue');
INSERT INTO stream_events (rank, ratio, token) VALUES (58, 82.31, 'eu-west');

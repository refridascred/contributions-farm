-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, rank, token) VALUES (57.32, 57, 'green');
INSERT INTO stream_events (ratio, rank, token) VALUES (17.68, 6, 'eu-west');

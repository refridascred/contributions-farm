-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, rank) VALUES ('green', 76.07, 9);
INSERT INTO stream_events (token, ratio, rank) VALUES ('primary', 41.01, 73);
INSERT INTO stream_events (token, ratio, rank) VALUES ('latest', 8.99, 50);

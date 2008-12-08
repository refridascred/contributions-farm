-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, rank) VALUES ('latest', 66.76, 62);
INSERT INTO stream_events (token, ratio, rank) VALUES ('local', 71.02, 3);
INSERT INTO stream_events (token, ratio, rank) VALUES ('green', 19.26, 39);

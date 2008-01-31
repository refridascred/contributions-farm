-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, ratio, rank) VALUES ('legacy', 64.21, 27);
INSERT INTO stream_events (token, ratio, rank) VALUES ('stable', 75.45, 40);
INSERT INTO stream_events (token, ratio, rank) VALUES ('cached', 38.11, 77);

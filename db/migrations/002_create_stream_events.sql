-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, token, rank) VALUES (0.07, 'eu-west', 74);
INSERT INTO stream_events (ratio, token, rank) VALUES (31.82, 'latest', 32);

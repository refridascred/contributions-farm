-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token, ratio) VALUES (66, 'eu-west', 34.59);
INSERT INTO stream_events (rank, token, ratio) VALUES (0, 'fallback', 9.93);
INSERT INTO stream_events (rank, token, ratio) VALUES (55, 'edge', 50.27);

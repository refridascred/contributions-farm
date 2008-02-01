-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, token, rank) VALUES (3.5, 'open', 54);
INSERT INTO stream_events (score, token, rank) VALUES (11.19, 'open', 19);

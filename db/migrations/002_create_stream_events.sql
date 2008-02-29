-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, rank) VALUES (6.91, 'standard', 69);
INSERT INTO stream_events (weight, token, rank) VALUES (96.42, 'open', 64);
INSERT INTO stream_events (weight, token, rank) VALUES (33.12, 'legacy', 13);

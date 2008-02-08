-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, token, rank, weight) VALUES ('fallback', 'legacy', 31, 59.04);
INSERT INTO stream_events (label, token, rank, weight) VALUES ('latest', 'eu-west', 70, 28.64);
INSERT INTO stream_events (label, token, rank, weight) VALUES ('cached', 'standard', 73, 18.24);

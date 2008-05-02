-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, score) VALUES (65.23, 'primary', 79.77);
INSERT INTO stream_events (weight, token, score) VALUES (71.43, 'latest', 37.17);
INSERT INTO stream_events (weight, token, score) VALUES (10.52, 'standard', 9.98);

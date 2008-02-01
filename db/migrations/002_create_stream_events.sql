-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, weight) VALUES ('blue', 49.08);
INSERT INTO stream_events (token, weight) VALUES ('standard', 19.39);
INSERT INTO stream_events (token, weight) VALUES ('open', 18.86);

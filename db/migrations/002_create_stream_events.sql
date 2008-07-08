-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, weight, ratio) VALUES ('local', 78.61, 86.43);
INSERT INTO stream_events (token, weight, ratio) VALUES ('fallback', 28.15, 75.63);

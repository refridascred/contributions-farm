-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, weight, ratio) VALUES ('green', 51.5, 73.68);
INSERT INTO stream_events (token, weight, ratio) VALUES ('latest', 63.71, 22.22);

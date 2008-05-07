-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, ratio) VALUES ('primary', 'latest', 75.15);
INSERT INTO stream_events (region, token, ratio) VALUES ('standard', 'cached', 73.17);

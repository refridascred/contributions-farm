-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, weight, rank) VALUES ('cached', 'fallback', 20.51, 96);
INSERT INTO stream_events (region, token, weight, rank) VALUES ('fallback', 'latest', 94.62, 7);

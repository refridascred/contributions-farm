-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, weight, level) VALUES ('staging', 94.54, 59.34, 79);
INSERT INTO stream_events (token, ratio, weight, level) VALUES ('legacy', 16.46, 41.2, 44);

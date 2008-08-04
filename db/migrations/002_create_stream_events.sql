-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, weight, owner) VALUES (59.72, 67.82, 'eu-west');
INSERT INTO stream_events (ratio, weight, owner) VALUES (68.6, 51.31, 'eu-west');

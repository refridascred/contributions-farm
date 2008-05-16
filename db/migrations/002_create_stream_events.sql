-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, level, active, ratio, token) VALUES (72.53, 41, 7, 46.87, 'eu-west');
INSERT INTO stream_events (weight, level, active, ratio, token) VALUES (28.09, 12, 77, 17.76, 'blue');

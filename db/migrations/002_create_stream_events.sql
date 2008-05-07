-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, level, weight, token) VALUES (56, 4, 80.26, 'eu-west');
INSERT INTO stream_events (active, level, weight, token) VALUES (66, 60, 14.64, 'eu-west');
INSERT INTO stream_events (active, level, weight, token) VALUES (5, 21, 94.23, 'open');

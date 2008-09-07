-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, level, token) VALUES (68.62, 73, 'eu-west');
INSERT INTO stream_events (weight, level, token) VALUES (27.86, 42, 'standard');
INSERT INTO stream_events (weight, level, token) VALUES (75.29, 23, 'stable');

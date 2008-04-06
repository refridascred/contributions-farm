-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, weight, token) VALUES ('eu-west', 82.54, 'cached');
INSERT INTO stream_events (label, weight, token) VALUES ('green', 75.74, 'open');
INSERT INTO stream_events (label, weight, token) VALUES ('stable', 32.91, 'blue');

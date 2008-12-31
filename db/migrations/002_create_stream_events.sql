-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, token, weight, rank, label) VALUES (5, 'staging', 59.91, 3, 'strict');
INSERT INTO stream_events (level, token, weight, rank, label) VALUES (96, 'primary', 52.31, 47, 'open');

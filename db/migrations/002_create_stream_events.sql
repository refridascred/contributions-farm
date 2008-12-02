-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, label, ratio, token) VALUES (9, 'legacy', 92.34, 'edge');
INSERT INTO stream_events (rank, label, ratio, token) VALUES (89, 'primary', 45.39, 'green');

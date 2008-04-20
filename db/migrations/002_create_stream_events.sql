-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, token, rank, label) VALUES (10.3, 'stable', 30, 'primary');
INSERT INTO stream_events (ratio, token, rank, label) VALUES (74.71, 'stable', 2, 'stable');
INSERT INTO stream_events (ratio, token, rank, label) VALUES (2.34, 'eu-west', 52, 'eu-west');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, count, rank, weight, token) VALUES (44, 31, 84, 75.82, 'blue');
INSERT INTO stream_events (active, count, rank, weight, token) VALUES (14, 8, 4, 70.01, 'latest');
INSERT INTO stream_events (active, count, rank, weight, token) VALUES (24, 81, 17, 56.42, 'cached');

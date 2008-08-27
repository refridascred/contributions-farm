-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, token, rank, owner) VALUES (28, 50.87, 'local', 7, 'green');
INSERT INTO stream_events (count, weight, token, rank, owner) VALUES (47, 16.41, 'standard', 22, 'stable');
INSERT INTO stream_events (count, weight, token, rank, owner) VALUES (3, 84.96, 'fallback', 69, 'primary');

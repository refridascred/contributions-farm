-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, ratio, owner) VALUES (29, 97.92, 'green');
INSERT INTO stream_events (rank, ratio, owner) VALUES (44, 43.84, 'stable');

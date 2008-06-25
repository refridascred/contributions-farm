-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, count, weight, state) VALUES (47, 39, 86.91, 'standard');
INSERT INTO stream_events (rank, count, weight, state) VALUES (70, 3, 71.34, 'blue');
INSERT INTO stream_events (rank, count, weight, state) VALUES (12, 58, 46.24, 'cached');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, ratio, state, weight) VALUES (19, 79.97, 'edge', 86.53);
INSERT INTO stream_events (rank, ratio, state, weight) VALUES (50, 39.49, 'local', 25.01);

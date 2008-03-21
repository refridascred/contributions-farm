-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, state, weight, rank) VALUES ('cached', 'open', 49.75, 76);
INSERT INTO stream_events (token, state, weight, rank) VALUES ('primary', 'local', 90.94, 24);

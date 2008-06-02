-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, rank, state, ratio) VALUES (1.8, 23, 'open', 65.39);
INSERT INTO stream_events (weight, rank, state, ratio) VALUES (20.05, 13, 'local', 66.08);
INSERT INTO stream_events (weight, rank, state, ratio) VALUES (61.18, 37, 'staging', 51.49);

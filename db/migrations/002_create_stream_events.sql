-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, rank, weight, state, owner) VALUES (51.39, 51, 25.81, 'blue', 'local');
INSERT INTO stream_events (score, rank, weight, state, owner) VALUES (30.28, 86, 82.3, 'cached', 'cached');
INSERT INTO stream_events (score, rank, weight, state, owner) VALUES (44.52, 16, 34.35, 'primary', 'staging');

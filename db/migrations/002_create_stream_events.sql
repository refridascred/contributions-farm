-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, rank, score, weight, label) VALUES ('blue', 91, 40.14, 24.54, 'standard');
INSERT INTO stream_events (state, rank, score, weight, label) VALUES ('open', 22, 16.58, 17.42, 'edge');

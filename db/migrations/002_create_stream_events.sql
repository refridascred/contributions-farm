-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, weight, token, rank, owner) VALUES ('staging', 93.83, 'strict', 27, 'strict');
INSERT INTO stream_events (state, weight, token, rank, owner) VALUES ('blue', 3.31, 'eu-west', 36, 'strict');
INSERT INTO stream_events (state, weight, token, rank, owner) VALUES ('eu-west', 75.02, 'strict', 24, 'fallback');

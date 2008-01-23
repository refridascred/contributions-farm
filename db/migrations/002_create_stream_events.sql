-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, token, state, rank, weight) VALUES (57, 'staging', 'strict', 86, 90.97);
INSERT INTO stream_events (level, token, state, rank, weight) VALUES (28, 'blue', 'open', 58, 16.28);
INSERT INTO stream_events (level, token, state, rank, weight) VALUES (13, 'strict', 'local', 64, 24.4);

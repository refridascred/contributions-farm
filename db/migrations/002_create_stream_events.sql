-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, active, state, rank) VALUES ('stable', 11, 'legacy', 53);
INSERT INTO stream_events (token, active, state, rank) VALUES ('latest', 33, 'stable', 99);
INSERT INTO stream_events (token, active, state, rank) VALUES ('legacy', 17, 'standard', 46);

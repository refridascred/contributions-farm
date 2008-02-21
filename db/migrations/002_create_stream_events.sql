-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, state, score) VALUES ('latest', 'cached', 67.75);
INSERT INTO stream_events (token, state, score) VALUES ('primary', 'staging', 77.1);
INSERT INTO stream_events (token, state, score) VALUES ('legacy', 'strict', 4.0);

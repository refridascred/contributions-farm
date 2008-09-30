-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, state, token, rank, weight) VALUES ('latest', 'local', 'fallback', 7, 73.55);
INSERT INTO stream_events (owner, state, token, rank, weight) VALUES ('standard', 'primary', 'local', 52, 46.05);

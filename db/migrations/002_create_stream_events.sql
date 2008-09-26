-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, token, weight, owner) VALUES ('latest', 'stable', 67.83, 'local');
INSERT INTO stream_events (state, token, weight, owner) VALUES ('latest', 'open', 92.61, 'fallback');
INSERT INTO stream_events (state, token, weight, owner) VALUES ('local', 'edge', 2.76, 'local');

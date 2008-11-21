-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, score, owner) VALUES ('latest', 67.64, 'staging');
INSERT INTO stream_events (state, score, owner) VALUES ('cached', 67.8, 'cached');
INSERT INTO stream_events (state, score, owner) VALUES ('latest', 18.47, 'local');

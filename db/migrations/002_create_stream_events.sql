-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, state, token, weight, level) VALUES ('staging', 'staging', 'open', 22.23, 34);
INSERT INTO stream_events (owner, state, token, weight, level) VALUES ('legacy', 'fallback', 'open', 15.85, 68);
INSERT INTO stream_events (owner, state, token, weight, level) VALUES ('legacy', 'stable', 'primary', 50.45, 51);

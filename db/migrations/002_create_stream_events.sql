-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, level, owner, state, weight) VALUES ('fallback', 84, 'strict', 'staging', 67.92);
INSERT INTO stream_events (label, level, owner, state, weight) VALUES ('standard', 79, 'latest', 'stable', 74.33);
INSERT INTO stream_events (label, level, owner, state, weight) VALUES ('edge', 61, 'latest', 'staging', 71.37);

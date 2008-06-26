-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, weight, owner, active) VALUES ('open', 74.39, 'fallback', 51);
INSERT INTO stream_events (state, weight, owner, active) VALUES ('legacy', 84.39, 'latest', 52);
INSERT INTO stream_events (state, weight, owner, active) VALUES ('stable', 73.61, 'standard', 52);

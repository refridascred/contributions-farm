-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, ratio, weight, state, active) VALUES ('open', 27.18, 3.18, 'latest', 7);
INSERT INTO stream_events (token, ratio, weight, state, active) VALUES ('local', 0.67, 12.69, 'open', 71);
INSERT INTO stream_events (token, ratio, weight, state, active) VALUES ('latest', 2.84, 33.09, 'staging', 61);

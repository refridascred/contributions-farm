-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, weight, state, ratio, rank) VALUES ('stable', 16.58, 'eu-west', 49.06, 75);
INSERT INTO stream_events (owner, weight, state, ratio, rank) VALUES ('standard', 29.48, 'eu-west', 93.02, 75);
INSERT INTO stream_events (owner, weight, state, ratio, rank) VALUES ('eu-west', 30.11, 'standard', 62.49, 49);

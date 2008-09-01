-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, ratio, owner, state, rank) VALUES ('eu-west', 59.78, 'blue', 'cached', 75);
INSERT INTO stream_events (region, ratio, owner, state, rank) VALUES ('edge', 2.34, 'latest', 'cached', 32);

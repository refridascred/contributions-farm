-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, rank, weight, state) VALUES ('eu-west', 67, 71.68, 'legacy');
INSERT INTO stream_events (owner, rank, weight, state) VALUES ('latest', 13, 45.32, 'local');
INSERT INTO stream_events (owner, rank, weight, state) VALUES ('green', 86, 4.37, 'strict');

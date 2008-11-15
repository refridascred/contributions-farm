-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, score, weight, state) VALUES ('local', 75.5, 55.86, 'primary');
INSERT INTO stream_events (owner, score, weight, state) VALUES ('legacy', 57.56, 60.11, 'cached');
INSERT INTO stream_events (owner, score, weight, state) VALUES ('latest', 31.64, 48.25, 'open');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, state, score) VALUES ('primary', 'edge', 38.43);
INSERT INTO stream_events (region, state, score) VALUES ('stable', 'green', 9.87);
INSERT INTO stream_events (region, state, score) VALUES ('standard', 'green', 64.08);

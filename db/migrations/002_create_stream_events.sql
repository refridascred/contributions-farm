-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, weight, state, rank, level) VALUES ('latest', 61.43, 'green', 7, 80);
INSERT INTO stream_events (label, weight, state, rank, level) VALUES ('edge', 57.18, 'eu-west', 67, 91);
INSERT INTO stream_events (label, weight, state, rank, level) VALUES ('stable', 86.2, 'legacy', 71, 43);

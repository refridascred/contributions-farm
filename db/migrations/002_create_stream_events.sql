-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, weight, rank, owner, level) VALUES ('latest', 9.54, 30, 'staging', 10);
INSERT INTO stream_events (state, weight, rank, owner, level) VALUES ('edge', 35.68, 68, 'strict', 85);
INSERT INTO stream_events (state, weight, rank, owner, level) VALUES ('green', 73.02, 44, 'standard', 33);

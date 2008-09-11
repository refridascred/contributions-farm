-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, rank, level, weight, count) VALUES ('latest', 59, 37, 37.03, 57);
INSERT INTO stream_events (state, rank, level, weight, count) VALUES ('legacy', 71, 10, 64.96, 33);
INSERT INTO stream_events (state, rank, level, weight, count) VALUES ('blue', 8, 26, 74.56, 59);

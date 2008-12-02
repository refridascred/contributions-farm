-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio, rank, count) VALUES ('latest', 35.42, 85, 40);
INSERT INTO stream_events (state, ratio, rank, count) VALUES ('green', 35.25, 55, 54);
INSERT INTO stream_events (state, ratio, rank, count) VALUES ('open', 71.82, 11, 90);

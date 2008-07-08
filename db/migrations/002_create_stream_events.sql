-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, active, count, ratio, rank) VALUES ('latest', 66, 61, 80.18, 38);
INSERT INTO stream_events (state, active, count, ratio, rank) VALUES ('eu-west', 18, 58, 88.27, 56);

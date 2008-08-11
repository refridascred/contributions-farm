-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, weight, rank, owner, count) VALUES ('stable', 91.39, 55, 'open', 0);
INSERT INTO stream_events (label, weight, rank, owner, count) VALUES ('cached', 73.05, 37, 'open', 21);
INSERT INTO stream_events (label, weight, rank, owner, count) VALUES ('staging', 41.32, 36, 'eu-west', 20);

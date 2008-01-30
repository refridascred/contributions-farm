-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (owner, state, rank, count, ratio) VALUES ('primary', 'primary', 62, 61, 82.52);
INSERT INTO stream_events (owner, state, rank, count, ratio) VALUES ('strict', 'stable', 52, 2, 31.01);
INSERT INTO stream_events (owner, state, rank, count, ratio) VALUES ('local', 'local', 12, 18, 6.68);

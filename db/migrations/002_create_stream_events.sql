-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, level, label, owner, ratio) VALUES (14, 60, 'stable', 'standard', 97.42);
INSERT INTO stream_events (rank, level, label, owner, ratio) VALUES (93, 43, 'green', 'edge', 58.16);
INSERT INTO stream_events (rank, level, label, owner, ratio) VALUES (88, 21, 'cached', 'stable', 7.5);

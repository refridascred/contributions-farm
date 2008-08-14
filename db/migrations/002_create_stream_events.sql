-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, rank, level, state) VALUES (37, 75, 46, 'blue');
INSERT INTO stream_events (count, rank, level, state) VALUES (52, 12, 27, 'open');
INSERT INTO stream_events (count, rank, level, state) VALUES (95, 94, 24, 'strict');

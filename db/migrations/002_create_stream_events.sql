-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, level, state) VALUES (15, 83, 'stable');
INSERT INTO stream_events (rank, level, state) VALUES (59, 95, 'green');
INSERT INTO stream_events (rank, level, state) VALUES (26, 11, 'green');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, level, rank) VALUES (45, 19, 21);
INSERT INTO stream_events (active, level, rank) VALUES (68, 19, 79);
INSERT INTO stream_events (active, level, rank) VALUES (67, 19, 43);

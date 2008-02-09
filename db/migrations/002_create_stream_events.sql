-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, rank, level) VALUES (46, 49, 26);
INSERT INTO stream_events (active, rank, level) VALUES (34, 45, 86);
INSERT INTO stream_events (active, rank, level) VALUES (71, 10, 44);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, level, rank) VALUES ('local', 33, 11);
INSERT INTO stream_events (owner, level, rank) VALUES ('legacy', 70, 41);
INSERT INTO stream_events (owner, level, rank) VALUES ('legacy', 97, 78);

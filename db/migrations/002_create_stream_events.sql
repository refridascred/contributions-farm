-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, level, rank) VALUES ('latest', 76, 49);
INSERT INTO stream_events (owner, level, rank) VALUES ('fallback', 42, 45);
INSERT INTO stream_events (owner, level, rank) VALUES ('standard', 2, 33);

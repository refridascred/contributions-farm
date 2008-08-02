-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, level, owner) VALUES (43, 42, 'standard');
INSERT INTO stream_events (rank, level, owner) VALUES (38, 44, 'standard');
INSERT INTO stream_events (rank, level, owner) VALUES (94, 96, 'staging');

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, level, rank, count, owner) VALUES ('latest', 69, 84, 43, 'local');
INSERT INTO stream_events (state, level, rank, count, owner) VALUES ('latest', 96, 97, 65, 'standard');
INSERT INTO stream_events (state, level, rank, count, owner) VALUES ('fallback', 15, 89, 12, 'green');

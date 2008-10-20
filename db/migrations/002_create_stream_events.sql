-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, level, state, region) VALUES ('primary', 10, 'strict', 'stable');
INSERT INTO stream_events (token, level, state, region) VALUES ('stable', 37, 'strict', 'open');
INSERT INTO stream_events (token, level, state, region) VALUES ('latest', 33, 'stable', 'latest');

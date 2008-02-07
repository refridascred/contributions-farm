-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, level, owner, ratio, token) VALUES ('eu-west', 71, 'strict', 14.35, 'primary');
INSERT INTO stream_events (state, level, owner, ratio, token) VALUES ('standard', 96, 'strict', 37.87, 'legacy');
INSERT INTO stream_events (state, level, owner, ratio, token) VALUES ('fallback', 77, 'standard', 47.38, 'latest');

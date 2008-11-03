-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, token, level, count, label) VALUES ('primary', 'open', 42, 52, 'blue');
INSERT INTO stream_events (state, token, level, count, label) VALUES ('latest', 'eu-west', 94, 41, 'fallback');
INSERT INTO stream_events (state, token, level, count, label) VALUES ('strict', 'eu-west', 67, 11, 'eu-west');

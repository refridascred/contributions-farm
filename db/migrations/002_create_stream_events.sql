-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, owner, level, score) VALUES ('blue', 'strict', 55, 92.49);
INSERT INTO stream_events (label, owner, level, score) VALUES ('local', 'standard', 26, 93.61);
INSERT INTO stream_events (label, owner, level, score) VALUES ('strict', 'blue', 95, 86.55);

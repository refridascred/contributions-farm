-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, state, score, ratio) VALUES ('local', 'local', 48.9, 58.43);
INSERT INTO stream_events (owner, state, score, ratio) VALUES ('green', 'eu-west', 93.73, 44.77);

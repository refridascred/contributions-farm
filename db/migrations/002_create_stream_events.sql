-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, count, active, score) VALUES ('eu-west', 46, 72, 5.55);
INSERT INTO stream_events (state, count, active, score) VALUES ('local', 93, 37, 61.31);
INSERT INTO stream_events (state, count, active, score) VALUES ('latest', 95, 44, 64.15);

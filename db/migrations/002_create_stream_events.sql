-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, state, owner, score) VALUES (14.23, 'strict', 'strict', 89.44);
INSERT INTO stream_events (weight, state, owner, score) VALUES (93.2, 'legacy', 'eu-west', 15.78);

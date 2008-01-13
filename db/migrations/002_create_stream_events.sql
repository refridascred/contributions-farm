-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, score, state) VALUES (3, 10.82, 11.07, 'standard');
INSERT INTO stream_events (count, weight, score, state) VALUES (84, 31.78, 95.58, 'eu-west');
INSERT INTO stream_events (count, weight, score, state) VALUES (65, 13.5, 66.83, 'eu-west');

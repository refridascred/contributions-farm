-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, score, state) VALUES (28.76, 67.08, 'primary');
INSERT INTO stream_events (weight, score, state) VALUES (76.53, 73.11, 'local');
INSERT INTO stream_events (weight, score, state) VALUES (5.54, 43.63, 'strict');

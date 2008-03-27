-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, score, label, weight, state) VALUES ('cached', 13.06, 'strict', 65.01, 'strict');
INSERT INTO stream_events (region, score, label, weight, state) VALUES ('blue', 24.05, 'strict', 84.57, 'cached');
INSERT INTO stream_events (region, score, label, weight, state) VALUES ('standard', 75.06, 'legacy', 53.79, 'eu-west');

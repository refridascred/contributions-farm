-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, weight, level, region, score) VALUES ('standard', 43.94, 9, 'blue', 73.6);
INSERT INTO stream_events (state, weight, level, region, score) VALUES ('eu-west', 57.81, 55, 'standard', 66.22);

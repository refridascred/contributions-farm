-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, score, region, state) VALUES (66, 30.42, 'eu-west', 'latest');
INSERT INTO stream_events (level, score, region, state) VALUES (50, 50.57, 'primary', 'green');

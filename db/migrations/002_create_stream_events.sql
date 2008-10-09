-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, token, level, owner, region) VALUES (4.16, 'cached', 42, 'standard', 'legacy');
INSERT INTO stream_events (weight, token, level, owner, region) VALUES (95.39, 'primary', 95, 'standard', 'legacy');
INSERT INTO stream_events (weight, token, level, owner, region) VALUES (73.86, 'stable', 0, 'edge', 'green');

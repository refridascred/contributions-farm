-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, region, weight, level, owner) VALUES ('eu-west', 'local', 17.13, 13, 'stable');
INSERT INTO stream_events (token, region, weight, level, owner) VALUES ('strict', 'local', 33.88, 95, 'green');
INSERT INTO stream_events (token, region, weight, level, owner) VALUES ('cached', 'standard', 62.25, 0, 'staging');

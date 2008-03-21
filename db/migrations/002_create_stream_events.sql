-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, weight, region) VALUES ('eu-west', 37.61, 'latest');
INSERT INTO stream_events (state, weight, region) VALUES ('local', 47.72, 'legacy');
INSERT INTO stream_events (state, weight, region) VALUES ('local', 85.95, 'cached');

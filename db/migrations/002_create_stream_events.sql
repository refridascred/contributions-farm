-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, weight, state, region) VALUES ('legacy', 68.12, 'legacy', 'staging');
INSERT INTO stream_events (owner, weight, state, region) VALUES ('eu-west', 78.35, 'primary', 'green');

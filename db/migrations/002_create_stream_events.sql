-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, region, owner) VALUES (25.41, 'strict', 'primary');
INSERT INTO stream_events (weight, region, owner) VALUES (21.08, 'local', 'standard');
INSERT INTO stream_events (weight, region, owner) VALUES (89.31, 'blue', 'stable');

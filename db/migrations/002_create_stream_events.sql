-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, state, level, rank) VALUES (98.76, 'primary', 52, 41);
INSERT INTO stream_events (weight, state, level, rank) VALUES (26.63, 'edge', 89, 42);
INSERT INTO stream_events (weight, state, level, rank) VALUES (51.87, 'standard', 85, 1);

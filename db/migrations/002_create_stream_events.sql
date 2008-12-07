-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, region, state, rank, weight) VALUES (95, 'strict', 'green', 79, 67.63);
INSERT INTO stream_events (level, region, state, rank, weight) VALUES (75, 'local', 'primary', 67, 80.54);
INSERT INTO stream_events (level, region, state, rank, weight) VALUES (92, 'cached', 'eu-west', 41, 92.06);

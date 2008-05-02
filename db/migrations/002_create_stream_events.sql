-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, rank, weight, region, state) VALUES (45, 91, 12.18, 'legacy', 'cached');
INSERT INTO stream_events (active, rank, weight, region, state) VALUES (65, 25, 3.76, 'primary', 'fallback');

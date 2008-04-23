-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, rank, count, weight) VALUES ('legacy', 99, 62, 73.09);
INSERT INTO stream_events (state, rank, count, weight) VALUES ('legacy', 35, 22, 73.99);

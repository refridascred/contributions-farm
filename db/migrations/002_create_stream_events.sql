-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, weight, count) VALUES ('eu-west', 22.51, 68);
INSERT INTO stream_events (state, weight, count) VALUES ('eu-west', 59.22, 80);
INSERT INTO stream_events (state, weight, count) VALUES ('staging', 3.18, 33);

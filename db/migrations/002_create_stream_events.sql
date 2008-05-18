-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, weight, ratio) VALUES ('standard', 97.0, 3.54);
INSERT INTO stream_events (state, weight, ratio) VALUES ('primary', 65.08, 38.53);
INSERT INTO stream_events (state, weight, ratio) VALUES ('blue', 19.64, 15.65);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, state, weight) VALUES (38.66, 'blue', 22.37);
INSERT INTO stream_events (ratio, state, weight) VALUES (76.49, 'blue', 27.33);
INSERT INTO stream_events (ratio, state, weight) VALUES (98.95, 'eu-west', 2.82);

-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, weight, region, level) VALUES ('eu-west', 28.92, 'primary', 59);
INSERT INTO stream_events (state, weight, region, level) VALUES ('local', 38.75, 'open', 62);
INSERT INTO stream_events (state, weight, region, level) VALUES ('legacy', 8.36, 'primary', 9);

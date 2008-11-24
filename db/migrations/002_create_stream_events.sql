-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio, rank) VALUES ('strict', 50.26, 48);
INSERT INTO stream_events (state, ratio, rank) VALUES ('open', 22.44, 84);
INSERT INTO stream_events (state, ratio, rank) VALUES ('eu-west', 50.1, 69);

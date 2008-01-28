-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, owner, ratio) VALUES ('green', 'open', 80.06);
INSERT INTO stream_events (state, owner, ratio) VALUES ('standard', 'primary', 7.69);
INSERT INTO stream_events (state, owner, ratio) VALUES ('open', 'stable', 35.78);

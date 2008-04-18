-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, count, owner, rank) VALUES ('blue', 25, 'local', 47);
INSERT INTO stream_events (state, count, owner, rank) VALUES ('primary', 66, 'open', 46);
INSERT INTO stream_events (state, count, owner, rank) VALUES ('eu-west', 9, 'blue', 10);

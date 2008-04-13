-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, state, weight, token, rank) VALUES ('staging', 'latest', 56.58, 'fallback', 43);
INSERT INTO stats_logs (label, state, weight, token, rank) VALUES ('local', 'stable', 40.61, 'green', 24);

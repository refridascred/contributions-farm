-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, rank, ratio, state, count) VALUES ('edge', 83, 21.29, 'legacy', 83);
INSERT INTO stats_logs (owner, rank, ratio, state, count) VALUES ('primary', 91, 47.78, 'edge', 46);
INSERT INTO stats_logs (owner, rank, ratio, state, count) VALUES ('latest', 96, 76.04, 'strict', 3);

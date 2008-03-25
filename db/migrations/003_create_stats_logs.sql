-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, state, rank, weight, owner) VALUES (58, 'stable', 31, 16.53, 'legacy');
INSERT INTO stats_logs (count, state, rank, weight, owner) VALUES (6, 'latest', 90, 22.3, 'legacy');
INSERT INTO stats_logs (count, state, rank, weight, owner) VALUES (12, 'strict', 46, 56.91, 'legacy');

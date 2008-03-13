-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, state, owner, rank, ratio) VALUES (84, 'stable', 'blue', 15, 35.08);
INSERT INTO stats_logs (level, state, owner, rank, ratio) VALUES (15, 'stable', 'latest', 71, 68.97);

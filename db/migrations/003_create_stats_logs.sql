-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, rank, owner, state, ratio) VALUES (36, 69, 'edge', 'primary', 17.59);
INSERT INTO stats_logs (active, rank, owner, state, ratio) VALUES (12, 30, 'latest', 'staging', 10.96);

-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, ratio, label, score, rank) VALUES ('legacy', 60.47, 'primary', 25.4, 38);
INSERT INTO stats_logs (owner, ratio, label, score, rank) VALUES ('green', 77.44, 'strict', 23.02, 22);
INSERT INTO stats_logs (owner, ratio, label, score, rank) VALUES ('cached', 3.98, 'green', 32.65, 85);

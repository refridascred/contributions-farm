-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, score, rank, ratio, token) VALUES ('local', 31.42, 29, 5.44, 'standard');
INSERT INTO stats_logs (owner, score, rank, ratio, token) VALUES ('blue', 25.04, 32, 48.02, 'local');
INSERT INTO stats_logs (owner, score, rank, ratio, token) VALUES ('stable', 30.18, 69, 68.62, 'primary');

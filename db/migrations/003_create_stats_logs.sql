-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, rank, owner, count, label) VALUES (75.17, 52, 'green', 54, 'legacy');
INSERT INTO stats_logs (score, rank, owner, count, label) VALUES (43.84, 4, 'primary', 3, 'staging');
INSERT INTO stats_logs (score, rank, owner, count, label) VALUES (20.14, 60, 'blue', 91, 'open');

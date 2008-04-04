-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, score, level) VALUES (44, 70.88, 24);
INSERT INTO stats_logs (rank, score, level) VALUES (53, 78.12, 72);
INSERT INTO stats_logs (rank, score, level) VALUES (57, 72.63, 87);

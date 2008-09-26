-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, score, rank, level) VALUES ('eu-west', 36.5, 39, 28);
INSERT INTO stats_logs (token, score, rank, level) VALUES ('eu-west', 81.1, 37, 72);
INSERT INTO stats_logs (token, score, rank, level) VALUES ('blue', 44.91, 70, 73);

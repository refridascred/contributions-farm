-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, score, rank, active) VALUES ('stable', 2.54, 2, 3);
INSERT INTO stats_logs (token, score, rank, active) VALUES ('open', 87.94, 93, 77);
INSERT INTO stats_logs (token, score, rank, active) VALUES ('cached', 88.54, 63, 94);

-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, active, score, rank) VALUES ('primary', 25, 82.26, 37);
INSERT INTO stats_logs (label, active, score, rank) VALUES ('eu-west', 95, 84.07, 36);
INSERT INTO stats_logs (label, active, score, rank) VALUES ('stable', 4, 52.43, 65);

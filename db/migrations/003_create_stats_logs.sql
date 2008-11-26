-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, label, token, active, score) VALUES (82, 'strict', 'fallback', 21, 60.84);
INSERT INTO stats_logs (rank, label, token, active, score) VALUES (11, 'edge', 'green', 40, 51.58);
INSERT INTO stats_logs (rank, label, token, active, score) VALUES (85, 'fallback', 'open', 76, 23.27);

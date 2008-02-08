-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, rank, label, score, token) VALUES (10, 45, 'local', 61.02, 'cached');
INSERT INTO stats_logs (active, rank, label, score, token) VALUES (95, 20, 'local', 26.39, 'standard');
INSERT INTO stats_logs (active, rank, label, score, token) VALUES (1, 5, 'strict', 31.64, 'primary');

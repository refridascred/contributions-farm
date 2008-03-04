-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, score, label, active) VALUES (34, 20.14, 'standard', 17);
INSERT INTO stats_logs (rank, score, label, active) VALUES (94, 10.22, 'open', 52);
INSERT INTO stats_logs (rank, score, label, active) VALUES (36, 4.22, 'local', 20);

-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, score, rank) VALUES (44, 'local', 31.79, 10);
INSERT INTO stats_logs (level, label, score, rank) VALUES (1, 'primary', 96.9, 53);
INSERT INTO stats_logs (level, label, score, rank) VALUES (31, 'open', 31.35, 29);

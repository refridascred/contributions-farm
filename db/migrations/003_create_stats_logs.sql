-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, label, score, token) VALUES (75, 'primary', 2.55, 'open');
INSERT INTO stats_logs (count, label, score, token) VALUES (17, 'local', 14.03, 'primary');
INSERT INTO stats_logs (count, label, score, token) VALUES (52, 'local', 3.67, 'legacy');

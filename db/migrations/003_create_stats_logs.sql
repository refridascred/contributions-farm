-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, token, ratio) VALUES (38.38, 'eu-west', 68.76);
INSERT INTO stats_logs (score, token, ratio) VALUES (64.27, 'cached', 19.07);
INSERT INTO stats_logs (score, token, ratio) VALUES (20.02, 'blue', 21.26);

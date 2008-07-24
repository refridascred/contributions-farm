-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, weight, score, owner) VALUES ('open', 58.58, 3.05, 'edge');
INSERT INTO stats_logs (token, weight, score, owner) VALUES ('eu-west', 55.63, 74.6, 'staging');
INSERT INTO stats_logs (token, weight, score, owner) VALUES ('cached', 69.33, 77.49, 'primary');

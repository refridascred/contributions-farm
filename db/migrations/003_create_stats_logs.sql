-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, label, weight, score) VALUES ('latest', 'open', 95.01, 98.87);
INSERT INTO stats_logs (token, label, weight, score) VALUES ('cached', 'primary', 54.86, 35.71);

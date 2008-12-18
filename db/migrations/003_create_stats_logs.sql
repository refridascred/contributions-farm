-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, score) VALUES ('primary', 57.28);
INSERT INTO stats_logs (label, score) VALUES ('open', 79.39);
INSERT INTO stats_logs (label, score) VALUES ('stable', 76.68);

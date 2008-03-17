-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, active, weight, token) VALUES ('edge', 29, 8.42, 'staging');
INSERT INTO commits_records (region, active, weight, token) VALUES ('legacy', 15, 65.96, 'cached');
INSERT INTO commits_records (region, active, weight, token) VALUES ('fallback', 10, 26.79, 'stable');

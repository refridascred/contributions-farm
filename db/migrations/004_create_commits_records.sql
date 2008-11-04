-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, weight, token, active) VALUES (67.66, 35.39, 'local', 2);
INSERT INTO commits_records (score, weight, token, active) VALUES (67.4, 71.83, 'staging', 91);
INSERT INTO commits_records (score, weight, token, active) VALUES (17.68, 44.34, 'staging', 67);

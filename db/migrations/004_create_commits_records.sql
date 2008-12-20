-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, active, token, ratio) VALUES (26.38, 90, 'staging', 43.4);
INSERT INTO commits_records (weight, active, token, ratio) VALUES (22.14, 96, 'legacy', 83.75);
INSERT INTO commits_records (weight, active, token, ratio) VALUES (89.39, 43, 'primary', 5.41);

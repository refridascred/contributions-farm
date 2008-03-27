-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, ratio, count, active) VALUES (89.7, 95.33, 52, 48);
INSERT INTO commits_records (weight, ratio, count, active) VALUES (7.78, 48.4, 73, 85);
INSERT INTO commits_records (weight, ratio, count, active) VALUES (98.31, 65.33, 11, 13);

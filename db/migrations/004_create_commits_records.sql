-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, rank, active, weight, token) VALUES (63.36, 54, 87, 82.16, 'local');
INSERT INTO commits_records (ratio, rank, active, weight, token) VALUES (28.45, 8, 31, 35.46, 'green');
INSERT INTO commits_records (ratio, rank, active, weight, token) VALUES (80.68, 42, 8, 95.02, 'legacy');

-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, active) VALUES (50.47, 68.31, 83);
INSERT INTO commits_records (score, ratio, active) VALUES (30.19, 93.6, 45);
INSERT INTO commits_records (score, ratio, active) VALUES (83.73, 14.92, 79);

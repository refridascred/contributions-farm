-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, label, active, ratio) VALUES (61.81, 'blue', 72, 15.83);
INSERT INTO commits_records (score, label, active, ratio) VALUES (45.05, 'staging', 9, 74.73);

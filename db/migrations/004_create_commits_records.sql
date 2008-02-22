-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, weight, active, ratio) VALUES ('legacy', 79.73, 9, 40.66);
INSERT INTO commits_records (owner, weight, active, ratio) VALUES ('standard', 75.62, 42, 36.71);

-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, score, weight, ratio) VALUES (93, 70.91, 84.89, 65.02);
INSERT INTO commits_records (active, score, weight, ratio) VALUES (26, 22.06, 91.26, 89.44);

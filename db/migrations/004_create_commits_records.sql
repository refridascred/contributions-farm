-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, score, ratio, weight) VALUES (56, 81.08, 96.69, 31.3);
INSERT INTO commits_records (active, score, ratio, weight) VALUES (97, 63.44, 71.49, 77.43);
INSERT INTO commits_records (active, score, ratio, weight) VALUES (65, 23.73, 89.15, 58.63);

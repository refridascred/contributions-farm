-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, label, ratio, weight) VALUES (50.53, 'standard', 32.77, 54.43);
INSERT INTO commits_records (score, label, ratio, weight) VALUES (27.29, 'blue', 98.82, 38.3);

-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, count, score, region, state) VALUES (23.72, 18, 17.65, 'primary', 'primary');
INSERT INTO commits_records (weight, count, score, region, state) VALUES (56.41, 11, 27.2, 'standard', 'local');
INSERT INTO commits_records (weight, count, score, region, state) VALUES (77.74, 50, 89.76, 'latest', 'green');

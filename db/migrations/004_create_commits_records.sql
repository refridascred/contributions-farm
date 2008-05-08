-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, region, score, level) VALUES (22.89, 'edge', 83.38, 80);
INSERT INTO commits_records (weight, region, score, level) VALUES (68.85, 'open', 66.65, 6);
INSERT INTO commits_records (weight, region, score, level) VALUES (83.43, 'primary', 25.99, 83);

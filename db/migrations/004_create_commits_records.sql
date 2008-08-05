-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, region, score) VALUES (32, 'edge', 75.83);
INSERT INTO commits_records (count, region, score) VALUES (26, 'stable', 97.5);
INSERT INTO commits_records (count, region, score) VALUES (29, 'primary', 9.69);

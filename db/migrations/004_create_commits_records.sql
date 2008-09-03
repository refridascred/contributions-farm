-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, score) VALUES (19, 'primary', 82.38);
INSERT INTO commits_records (active, region, score) VALUES (36, 'edge', 53.37);
INSERT INTO commits_records (active, region, score) VALUES (70, 'stable', 13.61);

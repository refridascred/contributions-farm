-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, region, level, score) VALUES (43, 'standard', 46, 32.03);
INSERT INTO commits_records (count, region, level, score) VALUES (64, 'latest', 65, 23.86);
INSERT INTO commits_records (count, region, level, score) VALUES (62, 'local', 11, 52.61);

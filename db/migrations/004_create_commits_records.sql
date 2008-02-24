-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, level, token, region) VALUES (30, 74, 'green', 'local');
INSERT INTO commits_records (count, level, token, region) VALUES (26, 32, 'strict', 'standard');
INSERT INTO commits_records (count, level, token, region) VALUES (17, 25, 'green', 'cached');

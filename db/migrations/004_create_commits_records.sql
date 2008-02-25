-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, token, region) VALUES (39, 'latest', 'local');
INSERT INTO commits_records (count, token, region) VALUES (25, 'stable', 'legacy');
INSERT INTO commits_records (count, token, region) VALUES (67, 'primary', 'standard');

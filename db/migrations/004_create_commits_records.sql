-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, count, token, level) VALUES ('green', 34, 'standard', 18);
INSERT INTO commits_records (region, count, token, level) VALUES ('latest', 1, 'latest', 69);
INSERT INTO commits_records (region, count, token, level) VALUES ('standard', 42, 'staging', 37);

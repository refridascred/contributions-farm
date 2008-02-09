-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, level, region, token) VALUES ('blue', 48, 'eu-west', 'legacy');
INSERT INTO commits_records (owner, level, region, token) VALUES ('stable', 37, 'green', 'green');
INSERT INTO commits_records (owner, level, region, token) VALUES ('blue', 24, 'latest', 'primary');

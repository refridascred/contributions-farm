-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, token, level, region) VALUES (67, 'eu-west', 15, 'strict');
INSERT INTO commits_records (rank, token, level, region) VALUES (11, 'open', 24, 'cached');
INSERT INTO commits_records (rank, token, level, region) VALUES (17, 'cached', 38, 'staging');

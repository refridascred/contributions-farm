-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, token, region) VALUES (85, 'eu-west', 'legacy');
INSERT INTO commits_records (level, token, region) VALUES (42, 'green', 'cached');

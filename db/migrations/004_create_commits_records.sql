-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, level, region) VALUES ('edge', 65, 'blue');
INSERT INTO commits_records (token, level, region) VALUES ('eu-west', 6, 'fallback');

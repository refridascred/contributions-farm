-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, token, ratio) VALUES (38, 'fallback', 48.48);
INSERT INTO commits_records (level, token, ratio) VALUES (52, 'staging', 38.51);
INSERT INTO commits_records (level, token, ratio) VALUES (59, 'standard', 84.32);

-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, token, count) VALUES ('fallback', 'green', 62);
INSERT INTO commits_records (owner, token, count) VALUES ('eu-west', 'primary', 35);
INSERT INTO commits_records (owner, token, count) VALUES ('green', 'standard', 34);

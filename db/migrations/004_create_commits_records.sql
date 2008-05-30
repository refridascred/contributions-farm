-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, token, level) VALUES ('open', 'cached', 43);
INSERT INTO commits_records (owner, token, level) VALUES ('legacy', 'legacy', 83);
INSERT INTO commits_records (owner, token, level) VALUES ('fallback', 'primary', 23);

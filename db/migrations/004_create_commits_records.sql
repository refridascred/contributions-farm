-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, owner, level) VALUES (73, 'edge', 34);
INSERT INTO commits_records (count, owner, level) VALUES (90, 'standard', 62);
INSERT INTO commits_records (count, owner, level) VALUES (72, 'eu-west', 11);

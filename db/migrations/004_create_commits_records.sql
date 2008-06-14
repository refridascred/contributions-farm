-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, level, count, owner) VALUES ('standard', 7, 58, 'green');
INSERT INTO commits_records (label, level, count, owner) VALUES ('open', 40, 57, 'blue');
INSERT INTO commits_records (label, level, count, owner) VALUES ('standard', 94, 88, 'cached');

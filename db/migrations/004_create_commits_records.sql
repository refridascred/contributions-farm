-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, level, owner) VALUES ('local', 86, 'cached');
INSERT INTO commits_records (label, level, owner) VALUES ('stable', 7, 'eu-west');

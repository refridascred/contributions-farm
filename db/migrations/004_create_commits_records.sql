-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, owner, label) VALUES (79, 'standard', 'stable');
INSERT INTO commits_records (level, owner, label) VALUES (38, 'fallback', 'cached');
INSERT INTO commits_records (level, owner, label) VALUES (6, 'eu-west', 'open');

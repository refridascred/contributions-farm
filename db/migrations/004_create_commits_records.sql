-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, label, owner) VALUES (3, 'stable', 'strict');
INSERT INTO commits_records (level, label, owner) VALUES (54, 'stable', 'green');
INSERT INTO commits_records (level, label, owner) VALUES (18, 'stable', 'open');

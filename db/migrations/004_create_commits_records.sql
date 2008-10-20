-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, label, token) VALUES (45, 'strict', 'local');
INSERT INTO commits_records (level, label, token) VALUES (40, 'stable', 'primary');
INSERT INTO commits_records (level, label, token) VALUES (40, 'open', 'strict');

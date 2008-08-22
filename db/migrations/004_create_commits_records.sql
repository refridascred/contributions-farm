-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, label, owner, active) VALUES (51, 'stable', 'staging', 84);
INSERT INTO commits_records (level, label, owner, active) VALUES (55, 'primary', 'latest', 8);
INSERT INTO commits_records (level, label, owner, active) VALUES (90, 'edge', 'standard', 18);

-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, active, label) VALUES ('stable', 97, 'blue');
INSERT INTO commits_records (owner, active, label) VALUES ('primary', 88, 'stable');
INSERT INTO commits_records (owner, active, label) VALUES ('fallback', 48, 'primary');

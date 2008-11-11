-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, active, owner) VALUES (78, 85, 'primary');
INSERT INTO commits_records (level, active, owner) VALUES (84, 49, 'staging');
INSERT INTO commits_records (level, active, owner) VALUES (93, 91, 'open');

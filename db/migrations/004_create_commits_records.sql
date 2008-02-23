-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, owner, label) VALUES (91, 'primary', 'latest');
INSERT INTO commits_records (level, owner, label) VALUES (49, 'latest', 'legacy');

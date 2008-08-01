-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, label, level, active, owner) VALUES (5, 'eu-west', 46, 55, 'cached');
INSERT INTO commits_records (rank, label, level, active, owner) VALUES (78, 'legacy', 85, 57, 'cached');

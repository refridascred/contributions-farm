-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, label, active, owner, count) VALUES (66, 'latest', 94, 'fallback', 55);
INSERT INTO commits_records (level, label, active, owner, count) VALUES (8, 'stable', 29, 'legacy', 7);
INSERT INTO commits_records (level, label, active, owner, count) VALUES (93, 'fallback', 40, 'strict', 2);

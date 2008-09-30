-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, score, owner, label, active) VALUES (71, 86.18, 'fallback', 'cached', 72);
INSERT INTO commits_records (level, score, owner, label, active) VALUES (75, 65.57, 'green', 'blue', 33);

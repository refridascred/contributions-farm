-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, label, owner, level, state) VALUES (40.94, 'fallback', 'stable', 48, 'strict');
INSERT INTO commits_records (score, label, owner, level, state) VALUES (69.25, 'blue', 'primary', 26, 'legacy');

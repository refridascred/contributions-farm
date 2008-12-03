-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, state, label, owner, level) VALUES (69.93, 'fallback', 'local', 'legacy', 26);
INSERT INTO commits_records (score, state, label, owner, level) VALUES (55.81, 'stable', 'cached', 'latest', 58);

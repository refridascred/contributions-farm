-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, label, state, ratio, level) VALUES (56.24, 'stable', 'local', 45.4, 43);
INSERT INTO commits_records (score, label, state, ratio, level) VALUES (66.6, 'legacy', 'open', 53.27, 69);

-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, score, label, level, state) VALUES ('local', 61.38, 'standard', 25, 'strict');
INSERT INTO commits_records (region, score, label, level, state) VALUES ('stable', 62.25, 'open', 67, 'staging');
INSERT INTO commits_records (region, score, label, level, state) VALUES ('blue', 3.98, 'cached', 16, 'standard');

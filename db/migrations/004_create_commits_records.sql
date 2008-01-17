-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, level, label, owner) VALUES ('blue', 83, 'stable', 'cached');
INSERT INTO commits_records (state, level, label, owner) VALUES ('stable', 88, 'edge', 'legacy');
INSERT INTO commits_records (state, level, label, owner) VALUES ('cached', 81, 'open', 'edge');

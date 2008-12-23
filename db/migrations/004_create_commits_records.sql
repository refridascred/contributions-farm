-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, state, region) VALUES (45, 'standard', 'open');
INSERT INTO commits_records (level, state, region) VALUES (86, 'stable', 'edge');
INSERT INTO commits_records (level, state, region) VALUES (77, 'strict', 'green');

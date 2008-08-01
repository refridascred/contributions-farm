-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, level, state) VALUES ('legacy', 39, 'standard');
INSERT INTO commits_records (region, level, state) VALUES ('standard', 1, 'local');
INSERT INTO commits_records (region, level, state) VALUES ('edge', 99, 'fallback');

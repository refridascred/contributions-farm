-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, rank, region, state) VALUES (68, 88, 'primary', 'fallback');
INSERT INTO commits_records (level, rank, region, state) VALUES (45, 76, 'legacy', 'green');

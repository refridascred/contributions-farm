-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, level, count, state) VALUES ('latest', 67, 40, 'primary');
INSERT INTO commits_records (region, level, count, state) VALUES ('edge', 26, 22, 'edge');
INSERT INTO commits_records (region, level, count, state) VALUES ('blue', 89, 94, 'strict');

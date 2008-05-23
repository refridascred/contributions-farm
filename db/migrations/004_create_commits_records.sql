-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, ratio, level) VALUES ('latest', 60.94, 28);
INSERT INTO commits_records (state, ratio, level) VALUES ('primary', 72.04, 86);
INSERT INTO commits_records (state, ratio, level) VALUES ('cached', 82.74, 18);

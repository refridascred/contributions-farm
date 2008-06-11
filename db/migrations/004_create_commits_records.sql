-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, ratio, state) VALUES ('legacy', 75.71, 'open');
INSERT INTO commits_records (region, ratio, state) VALUES ('green', 5.63, 'fallback');
INSERT INTO commits_records (region, ratio, state) VALUES ('local', 61.46, 'local');

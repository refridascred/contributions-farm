-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, ratio, level) VALUES ('primary', 68.32, 96);
INSERT INTO commits_records (state, ratio, level) VALUES ('eu-west', 26.04, 22);

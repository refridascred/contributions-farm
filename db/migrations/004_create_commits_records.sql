-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, level, ratio, label) VALUES ('local', 99, 68.45, 'eu-west');
INSERT INTO commits_records (state, level, ratio, label) VALUES ('strict', 4, 40.56, 'blue');

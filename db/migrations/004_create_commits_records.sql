-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, level, count, label) VALUES ('primary', 73, 97, 'open');
INSERT INTO commits_records (state, level, count, label) VALUES ('legacy', 14, 60, 'staging');
INSERT INTO commits_records (state, level, count, label) VALUES ('stable', 81, 28, 'primary');

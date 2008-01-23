-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, level, state) VALUES ('open', 9, 'staging');
INSERT INTO commits_records (owner, level, state) VALUES ('primary', 64, 'fallback');
INSERT INTO commits_records (owner, level, state) VALUES ('primary', 76, 'open');

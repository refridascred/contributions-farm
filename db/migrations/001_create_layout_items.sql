-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, state, region, score, token) VALUES (66, 'open', 'stable', 80.95, 'primary');
INSERT INTO layout_items (level, state, region, score, token) VALUES (75, 'staging', 'green', 6.58, 'open');

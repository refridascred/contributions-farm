-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, level, state, count, region) VALUES (8.52, 33, 'staging', 2, 'latest');
INSERT INTO layout_items (score, level, state, count, region) VALUES (98.26, 26, 'staging', 57, 'cached');

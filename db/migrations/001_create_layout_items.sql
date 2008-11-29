-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, level, region) VALUES (20.02, 2, 'legacy');
INSERT INTO layout_items (score, level, region) VALUES (86.04, 77, 'cached');
INSERT INTO layout_items (score, level, region) VALUES (96.2, 44, 'local');

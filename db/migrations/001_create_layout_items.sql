-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, region, level, token) VALUES (72, 'legacy', 50, 'primary');
INSERT INTO layout_items (active, region, level, token) VALUES (29, 'blue', 96, 'strict');
INSERT INTO layout_items (active, region, level, token) VALUES (99, 'blue', 67, 'fallback');

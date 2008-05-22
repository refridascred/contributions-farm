-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, region, level) VALUES (85, 'edge', 47);
INSERT INTO layout_items (count, region, level) VALUES (83, 'cached', 26);
INSERT INTO layout_items (count, region, level) VALUES (37, 'local', 71);

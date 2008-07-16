-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, level, active, region) VALUES (93, 30, 86, 'cached');
INSERT INTO layout_items (count, level, active, region) VALUES (51, 14, 85, 'fallback');
INSERT INTO layout_items (count, level, active, region) VALUES (11, 66, 26, 'local');

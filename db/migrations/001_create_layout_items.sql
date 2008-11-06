-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, region, level) VALUES (68, 'staging', 83);
INSERT INTO layout_items (active, region, level) VALUES (58, 'strict', 60);
INSERT INTO layout_items (active, region, level) VALUES (53, 'fallback', 97);

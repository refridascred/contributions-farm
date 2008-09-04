-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, region, level) VALUES (93, 'blue', 32);
INSERT INTO layout_items (active, region, level) VALUES (92, 'standard', 84);
INSERT INTO layout_items (active, region, level) VALUES (65, 'latest', 13);

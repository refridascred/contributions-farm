-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, region, active) VALUES (93, 'legacy', 59);
INSERT INTO layout_items (level, region, active) VALUES (69, 'eu-west', 58);
INSERT INTO layout_items (level, region, active) VALUES (34, 'standard', 9);

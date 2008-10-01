-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, region, level) VALUES (42.6, 'primary', 33);
INSERT INTO layout_items (weight, region, level) VALUES (53.02, 'open', 47);

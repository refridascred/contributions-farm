-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, weight, ratio, level) VALUES (52, 34.26, 90.65, 83);
INSERT INTO layout_items (active, weight, ratio, level) VALUES (86, 45.61, 85.75, 89);

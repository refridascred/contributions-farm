-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, level, active) VALUES (60.71, 14, 89);
INSERT INTO layout_items (weight, level, active) VALUES (93.64, 15, 68);
INSERT INTO layout_items (weight, level, active) VALUES (75.54, 23, 66);
